namespace OsuMapDeleter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSongsFolder = new System.Windows.Forms.Label();
            this.tbSongsPath = new System.Windows.Forms.TextBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.lblModes = new System.Windows.Forms.Label();
            this.checkBoxStd = new System.Windows.Forms.CheckBox();
            this.checkBoxTaiko = new System.Windows.Forms.CheckBox();
            this.checkBoxMania = new System.Windows.Forms.CheckBox();
            this.checkBoxCtb = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.labelProcessed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSongsFolder
            // 
            this.lblSongsFolder.AutoSize = true;
            this.lblSongsFolder.Location = new System.Drawing.Point(13, 15);
            this.lblSongsFolder.Name = "lblSongsFolder";
            this.lblSongsFolder.Size = new System.Drawing.Size(72, 13);
            this.lblSongsFolder.TabIndex = 0;
            this.lblSongsFolder.Text = "Songs Folder:";
            // 
            // tbSongsPath
            // 
            this.tbSongsPath.Location = new System.Drawing.Point(91, 12);
            this.tbSongsPath.Name = "tbSongsPath";
            this.tbSongsPath.Size = new System.Drawing.Size(237, 20);
            this.tbSongsPath.TabIndex = 1;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(341, 12);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(28, 20);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // lblModes
            // 
            this.lblModes.AutoSize = true;
            this.lblModes.Location = new System.Drawing.Point(13, 45);
            this.lblModes.Name = "lblModes";
            this.lblModes.Size = new System.Drawing.Size(42, 13);
            this.lblModes.TabIndex = 3;
            this.lblModes.Text = "Modes:";
            // 
            // checkBoxStd
            // 
            this.checkBoxStd.AutoSize = true;
            this.checkBoxStd.Location = new System.Drawing.Point(91, 44);
            this.checkBoxStd.Name = "checkBoxStd";
            this.checkBoxStd.Size = new System.Drawing.Size(69, 17);
            this.checkBoxStd.TabIndex = 4;
            this.checkBoxStd.Text = "Standard";
            this.checkBoxStd.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaiko
            // 
            this.checkBoxTaiko.AutoSize = true;
            this.checkBoxTaiko.Location = new System.Drawing.Point(91, 67);
            this.checkBoxTaiko.Name = "checkBoxTaiko";
            this.checkBoxTaiko.Size = new System.Drawing.Size(53, 17);
            this.checkBoxTaiko.TabIndex = 5;
            this.checkBoxTaiko.Text = "Taiko";
            this.checkBoxTaiko.UseVisualStyleBackColor = true;
            // 
            // checkBoxMania
            // 
            this.checkBoxMania.AutoSize = true;
            this.checkBoxMania.Location = new System.Drawing.Point(91, 90);
            this.checkBoxMania.Name = "checkBoxMania";
            this.checkBoxMania.Size = new System.Drawing.Size(55, 17);
            this.checkBoxMania.TabIndex = 6;
            this.checkBoxMania.Text = "Mania";
            this.checkBoxMania.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtb
            // 
            this.checkBoxCtb.AutoSize = true;
            this.checkBoxCtb.Location = new System.Drawing.Point(91, 113);
            this.checkBoxCtb.Name = "checkBoxCtb";
            this.checkBoxCtb.Size = new System.Drawing.Size(54, 17);
            this.checkBoxCtb.TabIndex = 7;
            this.checkBoxCtb.Text = "Catch";
            this.checkBoxCtb.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(213, 107);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check Files";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labelProcessing
            // 
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.Location = new System.Drawing.Point(210, 67);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(0, 13);
            this.labelProcessing.TabIndex = 11;
            // 
            // labelProcessed
            // 
            this.labelProcessed.AutoSize = true;
            this.labelProcessed.Location = new System.Drawing.Point(210, 86);
            this.labelProcessed.Name = "labelProcessed";
            this.labelProcessed.Size = new System.Drawing.Size(0, 13);
            this.labelProcessed.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 145);
            this.Controls.Add(this.labelProcessed);
            this.Controls.Add(this.labelProcessing);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.checkBoxCtb);
            this.Controls.Add(this.checkBoxMania);
            this.Controls.Add(this.checkBoxTaiko);
            this.Controls.Add(this.checkBoxStd);
            this.Controls.Add(this.lblModes);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.tbSongsPath);
            this.Controls.Add(this.lblSongsFolder);
            this.Name = "MainForm";
            this.Text = "Osu Diff Deleter";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongsFolder;
        private System.Windows.Forms.TextBox tbSongsPath;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Label lblModes;
        private System.Windows.Forms.CheckBox checkBoxStd;
        private System.Windows.Forms.CheckBox checkBoxTaiko;
        private System.Windows.Forms.CheckBox checkBoxMania;
        private System.Windows.Forms.CheckBox checkBoxCtb;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Label labelProcessed;
    }
}

