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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            linkLabel4 = new LinkLabel();
            pictureBox1 = new PictureBox();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            linkLabel7 = new LinkLabel();
            textBox1 = new TextBox();
            linkLabel8 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChooseDosGameFileDirectory);
            groupBox1.Controls.Add(tbDosGameFileDirectory);
            groupBox1.Location = new Point(12, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Set Game File Path ( Step 1 of 4 )";
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
            groupBox2.Location = new Point(12, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(984, 118);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Game File Path Contents";
            // 
            // lbDosGameFiles
            // 
            lbDosGameFiles.BackColor = SystemColors.Control;
            lbDosGameFiles.BorderStyle = BorderStyle.None;
            lbDosGameFiles.FormattingEnabled = true;
            lbDosGameFiles.ItemHeight = 15;
            lbDosGameFiles.Location = new Point(6, 22);
            lbDosGameFiles.Name = "lbDosGameFiles";
            lbDosGameFiles.Size = new Size(972, 75);
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
            groupBox3.Text = "Set JsDos Bundle Output Path ( Step 3 of 4 )";
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
            groupBox4.Text = "Set JsDos Bundle Name ( Step 4 of 4 )";
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
            groupBox5.Text = "Set Game Executable Path ( Step 2 of 4 )";
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
            lbLog.BackColor = SystemColors.Control;
            lbLog.BorderStyle = BorderStyle.None;
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(6, 22);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(972, 135);
            lbLog.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(55, 18);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "JsDos Overview";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(149, 18);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(98, 15);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "JsDos On Discord";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(440, 18);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(54, 15);
            linkLabel3.TabIndex = 13;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "DosZone";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 14;
            label1.Text = "Links:";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(253, 18);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(94, 15);
            linkLabel4.TabIndex = 15;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "JsDos On Twitter";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(943, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(353, 18);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(81, 15);
            linkLabel5.TabIndex = 17;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Support JsDos";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Location = new Point(500, 18);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(125, 15);
            linkLabel6.TabIndex = 18;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "DosZone Game Studio";
            linkLabel6.LinkClicked += linkLabel6_LinkClicked;
            // 
            // linkLabel7
            // 
            linkLabel7.AutoSize = true;
            linkLabel7.Location = new Point(631, 18);
            linkLabel7.Name = "linkLabel7";
            linkLabel7.Size = new Size(99, 15);
            linkLabel7.TabIndex = 19;
            linkLabel7.TabStop = true;
            linkLabel7.Text = "DosZone Browser";
            linkLabel7.LinkClicked += linkLabel7_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(984, 45);
            textBox1.TabIndex = 20;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel8
            // 
            linkLabel8.AutoSize = true;
            linkLabel8.Location = new Point(736, 18);
            linkLabel8.Name = "linkLabel8";
            linkLabel8.Size = new Size(104, 15);
            linkLabel8.TabIndex = 21;
            linkLabel8.TabStop = true;
            linkLabel8.Text = "GitHub Repository";
            linkLabel8.LinkClicked += linkLabel8_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            ControlBox = false;
            Controls.Add(linkLabel8);
            Controls.Add(textBox1);
            Controls.Add(linkLabel7);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel5);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel4);
            Controls.Add(label1);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JsDos Bundle Packer (c) Leo C. Bergamo";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label1;
        private LinkLabel linkLabel4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private TextBox textBox1;
        private LinkLabel linkLabel8;
    }
}
