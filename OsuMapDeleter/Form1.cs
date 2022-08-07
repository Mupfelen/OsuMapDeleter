using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace OsuMapDeleter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool delStd = false;
        private bool delTaiko = false;
        private bool delMania = false;
        private bool delCtb = false;
        private List<string> filesToDelete = new List<string>();
        private int filesProcessed;
        private int filesFound;
        private bool done = false;

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            string path;
            string[] files;

            using (var cofd = new CommonOpenFileDialog())
            {
                cofd.InitialDirectory = "C:\\";
                cofd.IsFolderPicker = true;

                CommonFileDialogResult result = cofd.ShowDialog();

                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(cofd.FileName))
                {
                    tbSongsPath.Text = cofd.FileName;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            filesProcessed = 0;
            filesFound = 0;
            done = false;
            delStd = checkBoxStd.Checked;
            delTaiko = checkBoxTaiko.Checked;
            delMania = checkBoxMania.Checked;
            delCtb = checkBoxCtb.Checked;

            if (!Directory.Exists(tbSongsPath.Text))
            {
                MessageBox.Show("Please specify a valid folder");
                return;
            }

            var songsPath = tbSongsPath.Text;

            Task.Run(() => ReadFiles(songsPath));
        }

        private async Task ReadFiles(string songsPath)
        {
            List<Task> tasks = new List<Task>();

            foreach (var file in Directory.EnumerateFiles(songsPath, "*.osu", SearchOption.AllDirectories))
            {
                tasks.Add(Task.Run(() => CheckFile(file)));
            }

            await Task.WhenAll(tasks);
            Console.WriteLine("Done!");
            done = true;
        }

        private async Task CheckFile(string file)
        {
            using (var reader = new StreamReader(file))
            {
                string readText;
                var counter = 0;
                filesProcessed++;

                while ((readText = await reader.ReadLineAsync()) != null)
                {
                    if (ContainsModeString(readText))
                    {
                        filesFound++;
                        filesToDelete.Add(file);
                        await Task.Run(() =>
                        {
                            Console.WriteLine("Processed: (" + filesFound + "/" + filesProcessed + ")");
                        });
                        break;
                    }

                    if (counter >= 20) break;
                    counter++;
                }
            }
        }

        private bool ContainsModeString(string line)
        {
            if (delStd && line.Contains("Mode: 0")) return true;
            if (delTaiko && line.Contains("Mode: 1")) return true;
            if (delCtb && line.Contains("Mode: 2")) return true;
            if (delMania && line.Contains("Mode: 3")) return true;
            return false;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!done) return;

            string messageBoxText = "Do you really want to delete?";
            string caption = "Difficulty Deletion";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            var result = MessageBox.Show(messageBoxText, caption, button, icon);

            switch (result)
            {
                case DialogResult.Yes: Task.Run(DeleteFiles);
                    break;
                case DialogResult.No: break;
            }
        }

        private async Task DeleteFiles()
        {
            List<Task> tasks = new List<Task>();

            foreach (string file in filesToDelete)
            {
                Console.WriteLine("Deleted: " + file);
                tasks.Add(Task.Run(() => File.Delete(file)));
            }

            await Task.WhenAll(tasks);

            await CleanupDirs(tbSongsPath.Text);
        }

        private async Task CleanupDirs(string songsPath)
        {
            List<Task> tasks = new List<Task>();

            foreach (var dir in Directory.GetDirectories(songsPath, "*", SearchOption.TopDirectoryOnly))
            {
                tasks.Add(Task.Run(() => CheckDirForEmptyAndDelete(dir)));
            }
        }

        private void CheckDirForEmptyAndDelete(string dir)
        {
            if (!Directory.Exists(dir)) return;

            var files = Directory.GetFiles(dir, "*.osu", SearchOption.TopDirectoryOnly);

            if (files.Length == 0)
            {
                Console.WriteLine("Deleted: " + dir);
                Directory.Delete(dir, true);
            }
        }
    }
}
