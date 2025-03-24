namespace JsDosPacker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnChooseDosGameFileDirectory = new Button();
            tbDosGameFileDirectory = new TextBox();
            groupBox2 = new GroupBox();
            lbDosGameFiles = new ListBox();
            groupBox3 = new GroupBox();
            btnChooseJsDosOutputDirectory = new Button();
            tbJsDosArchiveOutputPath = new TextBox();
            groupBox4 = new GroupBox();
            tbJsDosArchiveName = new TextBox();
            btnCustomizeDosBoxConf = new Button();
            btnCustomizeJsDosJson = new Button();
            btnCreatePackage = new Button();
            groupBox5 = new GroupBox();
            btnChooseDosGameExecutable = new Button();
            tbDosGameExecutable = new TextBox();
            dlgSelectFile = new OpenFileDialog();
            dlgSelectFolder = new FolderBrowserDialog();
            btnCustomizeStartBatchFile = new Button();
            btnExit = new Button();
            groupBox6 = new GroupBox();
            lbLog = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChooseDosGameFileDirectory);
            groupBox1.Controls.Add(tbDosGameFileDirectory);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DOS Game File Directory";
            // 
            // btnChooseDosGameFileDirectory
            // 
            btnChooseDosGameFileDirectory.Location = new Point(903, 22);
            btnChooseDosGameFileDirectory.Name = "btnChooseDosGameFileDirectory";
            btnChooseDosGameFileDirectory.Size = new Size(75, 23);
            btnChooseDosGameFileDirectory.TabIndex = 1;
            btnChooseDosGameFileDirectory.Text = "Choose";
            btnChooseDosGameFileDirectory.UseVisualStyleBackColor = true;
            btnChooseDosGameFileDirectory.Click += btnChooseDosGameFileDirectory_Click;
            // 
            // tbDosGameFileDirectory
            // 
            tbDosGameFileDirectory.Location = new Point(6, 22);
            tbDosGameFileDirectory.Name = "tbDosGameFileDirectory";
            tbDosGameFileDirectory.Size = new Size(891, 23);
            tbDosGameFileDirectory.TabIndex = 0;
            tbDosGameFileDirectory.TextChanged += tbDosGameFileDirectory_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbDosGameFiles);
            groupBox2.Location = new Point(12, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(984, 217);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "DOS Game Files";
            // 
            // lbDosGameFiles
            // 
            lbDosGameFiles.FormattingEnabled = true;
            lbDosGameFiles.ItemHeight = 15;
            lbDosGameFiles.Location = new Point(6, 22);
            lbDosGameFiles.Name = "lbDosGameFiles";
            lbDosGameFiles.Size = new Size(972, 184);
            lbDosGameFiles.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnChooseJsDosOutputDirectory);
            groupBox3.Controls.Add(tbJsDosArchiveOutputPath);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(12, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(984, 65);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "JsDos Archive Output Path";
            // 
            // btnChooseJsDosOutputDirectory
            // 
            btnChooseJsDosOutputDirectory.Location = new Point(903, 22);
            btnChooseJsDosOutputDirectory.Name = "btnChooseJsDosOutputDirectory";
            btnChooseJsDosOutputDirectory.Size = new Size(75, 23);
            btnChooseJsDosOutputDirectory.TabIndex = 2;
            btnChooseJsDosOutputDirectory.Text = "Choose";
            btnChooseJsDosOutputDirectory.UseVisualStyleBackColor = true;
            btnChooseJsDosOutputDirectory.Click += btnChooseJsDosOutputDirectory_Click;
            // 
            // tbJsDosArchiveOutputPath
            // 
            tbJsDosArchiveOutputPath.Location = new Point(6, 22);
            tbJsDosArchiveOutputPath.Name = "tbJsDosArchiveOutputPath";
            tbJsDosArchiveOutputPath.Size = new Size(891, 23);
            tbJsDosArchiveOutputPath.TabIndex = 0;
            tbJsDosArchiveOutputPath.TextChanged += tbJsDosArchiveOutputPath_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbJsDosArchiveName);
            groupBox4.Enabled = false;
            groupBox4.Location = new Point(12, 448);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(984, 65);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "JsDos Archive Name";
            // 
            // tbJsDosArchiveName
            // 
            tbJsDosArchiveName.Location = new Point(6, 22);
            tbJsDosArchiveName.Name = "tbJsDosArchiveName";
            tbJsDosArchiveName.Size = new Size(972, 23);
            tbJsDosArchiveName.TabIndex = 0;
            tbJsDosArchiveName.TextChanged += tbJsDosArchiveName_TextChanged;
            // 
            // btnCustomizeDosBoxConf
            // 
            btnCustomizeDosBoxConf.Location = new Point(12, 694);
            btnCustomizeDosBoxConf.Name = "btnCustomizeDosBoxConf";
            btnCustomizeDosBoxConf.Size = new Size(217, 23);
            btnCustomizeDosBoxConf.TabIndex = 4;
            btnCustomizeDosBoxConf.Text = "Customize DosBox Configuration File";
            btnCustomizeDosBoxConf.UseVisualStyleBackColor = true;
            btnCustomizeDosBoxConf.Click += btnCustomizeDosBoxConf_Click;
            // 
            // btnCustomizeJsDosJson
            // 
            btnCustomizeJsDosJson.Location = new Point(458, 694);
            btnCustomizeJsDosJson.Name = "btnCustomizeJsDosJson";
            btnCustomizeJsDosJson.Size = new Size(217, 23);
            btnCustomizeJsDosJson.TabIndex = 5;
            btnCustomizeJsDosJson.Text = "Customize JsDos Json File";
            btnCustomizeJsDosJson.UseVisualStyleBackColor = true;
            btnCustomizeJsDosJson.Click += btnCustomizeJsDosJson_Click;
            // 
            // btnCreatePackage
            // 
            btnCreatePackage.Location = new Point(681, 694);
            btnCreatePackage.Name = "btnCreatePackage";
            btnCreatePackage.Size = new Size(217, 23);
            btnCreatePackage.TabIndex = 6;
            btnCreatePackage.Text = "Create";
            btnCreatePackage.UseVisualStyleBackColor = true;
            btnCreatePackage.Click += btnCreatePackage_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnChooseDosGameExecutable);
            groupBox5.Controls.Add(tbDosGameExecutable);
            groupBox5.Enabled = false;
            groupBox5.Location = new Point(12, 306);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(984, 65);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "DOS Game Executable";
            // 
            // btnChooseDosGameExecutable
            // 
            btnChooseDosGameExecutable.Location = new Point(903, 22);
            btnChooseDosGameExecutable.Name = "btnChooseDosGameExecutable";
            btnChooseDosGameExecutable.Size = new Size(75, 23);
            btnChooseDosGameExecutable.TabIndex = 2;
            btnChooseDosGameExecutable.Text = "Choose";
            btnChooseDosGameExecutable.UseVisualStyleBackColor = true;
            btnChooseDosGameExecutable.Click += btnChooseDosGameExecutable_Click;
            // 
            // tbDosGameExecutable
            // 
            tbDosGameExecutable.Location = new Point(6, 22);
            tbDosGameExecutable.Name = "tbDosGameExecutable";
            tbDosGameExecutable.Size = new Size(891, 23);
            tbDosGameExecutable.TabIndex = 0;
            tbDosGameExecutable.TextChanged += tbDosGameExecutable_TextChanged;
            // 
            // dlgSelectFile
            // 
            dlgSelectFile.FileName = "openFileDialog1";
            // 
            // btnCustomizeStartBatchFile
            // 
            btnCustomizeStartBatchFile.Location = new Point(235, 694);
            btnCustomizeStartBatchFile.Name = "btnCustomizeStartBatchFile";
            btnCustomizeStartBatchFile.Size = new Size(217, 23);
            btnCustomizeStartBatchFile.TabIndex = 8;
            btnCustomizeStartBatchFile.Text = "Customize Start Batch File";
            btnCustomizeStartBatchFile.UseVisualStyleBackColor = true;
            btnCustomizeStartBatchFile.Click += btnCustomizeStartBatchFile_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(904, 694);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbLog);
            groupBox6.Location = new Point(12, 519);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(984, 169);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Log";
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(6, 22);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(972, 139);
            lbLog.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            ControlBox = false;
            Controls.Add(groupBox6);
            Controls.Add(btnExit);
            Controls.Add(btnCustomizeStartBatchFile);
            Controls.Add(groupBox5);
            Controls.Add(btnCreatePackage);
            Controls.Add(btnCustomizeJsDosJson);
            Controls.Add(btnCustomizeDosBoxConf);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JsDos Packer (c) Leo C. Bergamo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnChooseDosGameFileDirectory;
        private TextBox tbDosGameFileDirectory;
        private GroupBox groupBox2;
        private ListBox lbDosGameFiles;
        private GroupBox groupBox3;
        private Button btnCustomizeJsDosJson;
        private TextBox tbJsDosArchiveOutputPath;
        private Button btnChooseJsDosOutputDirectory;
        private GroupBox groupBox4;
        private TextBox tbJsDosArchiveName;
        private Button btnCustomizeDosBoxConf;
        private Button btnCreatePackage;
        private GroupBox groupBox5;
        private Button btnChooseDosGameExecutable;
        private TextBox tbDosGameExecutable;
        private OpenFileDialog dlgSelectFile;
        private FolderBrowserDialog dlgSelectFolder;
        private Button btnCustomizeStartBatchFile;
        private Button btnExit;
        private GroupBox groupBox6;
        private ListBox lbLog;
    }
}
