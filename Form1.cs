using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Forms;

namespace JsDosPacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnChooseDosGameFileDirectory_Click(object _objSender, EventArgs _eaEventArgs)
        {

            dlgSelectFolder.InitialDirectory = "c:\\";
            dlgSelectFolder.ShowDialog();
            tbDosGameFileDirectory.Text = dlgSelectFolder.SelectedPath;
            tbJsDosArchiveOutputPath.Text = dlgSelectFolder.SelectedPath;
            tbJsDosArchiveName.Text = Path.GetFileName(dlgSelectFolder.SelectedPath);
            Variables.strDosGameFilePath = dlgSelectFolder.SelectedPath;

        }

        private void btnChooseJsDosOutputDirectory_Click(object _objSender, EventArgs _eaEventArgs)
        {
            dlgSelectFolder.InitialDirectory = "c:\\";
            dlgSelectFolder.ShowDialog();
            tbJsDosArchiveOutputPath.Text = dlgSelectFolder.SelectedPath;
            Variables.strJsDosArchiveOutputPath = dlgSelectFolder.SelectedPath;
        }

        private void btnCustomizeDosBoxConf_Click(object _objSender, EventArgs _eaEventArgs)
        {
            if (Variables.strDosBoxConf == string.Empty)
            {
                Form _frmEditor = new Form2(Variables.strDefDosBoxConf, "dosbox_conf");
                _frmEditor.ShowDialog();
            }
            else
            {
                Form _frmEditor = new Form2(Variables.strDosBoxConf, "dosbox_conf");
                _frmEditor.ShowDialog();
            }
        }

        private void btnCustomizeJsDosJson_Click(object _objSender, EventArgs _eaEventArgs)
        {
            if (Variables.strJsDosJson == string.Empty)
            {
                Form _frmEditor = new Form2(Variables.strDefJsDosJson, "jsdos_json");
                _frmEditor.ShowDialog();
            }
            else
            {
                Form _frmEditor = new Form2(Variables.strJsDosJson, "jsdos_json");
                _frmEditor.ShowDialog();
            }
        }

        private void btnCreatePackage_Click(object _objSender, EventArgs _eaEventArgs)
        {


            if (Variables.strDosBoxConf == string.Empty)
            {
                MessageBox.Show("DosBox configuration not defined!");
                return;
            }

            if (Variables.strDosGameExecutablePath == string.Empty)
            {
                MessageBox.Show("DOS game executable path not defined!");
                return;
            }

            if (Variables.strDosGameFilePath == string.Empty)
            {
                MessageBox.Show("DOS game file directory not defined!");
                return;
            }

            if (Variables.strDosGameStartBatchFile == string.Empty)
            {
                MessageBox.Show("DOS game start batch file not defined!");
                return;
            }

            if (Variables.strJsDosArchiveName == string.Empty)
            {
                MessageBox.Show("JsDos archive name not defined!");
                return;
            }

            if (Variables.strJsDosArchiveOutputPath == string.Empty)
            {
                MessageBox.Show("JsDos archive output path not defined!");
                return;
            }

            if (Variables.strJsDosJson == string.Empty)
            {
                MessageBox.Show("JsDos json not defined!");
                return;
            }

            try
            {
                string _strTempBundlePath = Directory.CreateTempSubdirectory().FullName;
                string _strTempBundleJsDosPath = Directory.CreateDirectory(Path.Combine(_strTempBundlePath, ".jsdos")).FullName;
                string _strJsDosOutputArchiveFilespec = Path.Combine(Variables.strJsDosArchiveOutputPath, "jsdos_bundle_" + Variables.strJsDosArchiveName + ".jsdos");

                lbLog.Items.Add("Creating bundle, please wait...");
                lbLog.Items.Add("Using temporary directory: '" + _strTempBundlePath + "'...");
                if (File.Exists(_strJsDosOutputArchiveFilespec))
                {
                    lbLog.Items.Add("Found old bundle: '" + _strJsDosOutputArchiveFilespec + "'...");
                    lbLog.Items.Add("Deleting old bundle...");
                    File.Delete(_strJsDosOutputArchiveFilespec);
                }
                lbLog.Items.Add("Copying file(s) to temporary directory...");
                foreach (string __strFilePath in lbDosGameFiles.Items)
                {
                    lbLog.Items.Add("Copying file: '" + __strFilePath + "'...");
                    File.Copy(__strFilePath, Path.Combine(_strTempBundlePath, Path.GetFileName(__strFilePath)), true);
                }

                lbLog.Items.Add("Creating and storing dosbox configuration in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundleJsDosPath, "dosbox.conf"), Utilities.strTrimStartMultiLineString(Variables.strDosBoxConf));
                lbLog.Items.Add("Creating and storing jsdos json in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundleJsDosPath, "jsdos.json"), Utilities.strTrimStartMultiLineString(Variables.strJsDosJson));
                lbLog.Items.Add("Creating and storing start batch file in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundlePath, "start.bat"), Utilities.strTrimStartMultiLineString(string.Format(Variables.strDosGameStartBatchFile, Path.GetFileName(Variables.strDosGameExecutablePath))));
                lbLog.Items.Add("Creating and storing bundle: '" + Path.GetFileName(_strJsDosOutputArchiveFilespec) + "' of temporary files in directory: '" + Path.GetDirectoryName(_strJsDosOutputArchiveFilespec) + "'...");
                ZipFile.CreateFromDirectory(_strTempBundlePath, _strJsDosOutputArchiveFilespec);
                lbLog.Items.Add("Removing temporary directory...");
                Utilities.vDeleteDirectory(_strTempBundlePath);
                lbLog.Items.Add("Bundle created!");
                lbLog.SelectedIndex = lbLog.Items.Count - 1;
                lbLog.SelectedIndex = -1;
                Process.Start("explorer.exe", "/select, " + Path.GetDirectoryName(_strJsDosOutputArchiveFilespec));
            }
            catch (Exception _objExc)
            {
                lbLog.Items.Add("Bundle creation failed: '" + _objExc.Message + "'...");
                Utilities.vConLog(_objExc.ToString());
                lbLog.SelectedIndex = lbLog.Items.Count - 1;
                lbLog.SelectedIndex = -1;
            }
        }

        private void btnChooseDosGameExecutable_Click(object _objSender, EventArgs _eaEventArgs)
        {
            dlgSelectFile.Title = "Choose DOS Game Startup File";
            dlgSelectFile.Filter = "Executable Files (*.exe)|*.exe|Command Files (*.com)|*.com|Batch Files (*.bat)|*.bat";
            dlgSelectFile.InitialDirectory = tbDosGameFileDirectory.Text;
            dlgSelectFile.ShowDialog();
            tbDosGameExecutable.Text = dlgSelectFile.FileName;
            Variables.strDosGameExecutablePath = dlgSelectFile.FileName;
        }

        private void tbJsDosArchiveName_TextChanged(object _objSender, EventArgs _eaEventArgs)
        {
            Variables.strJsDosArchiveName = tbJsDosArchiveName.Text;
        }

        private void tbJsDosArchiveOutputPath_TextChanged(object sender, EventArgs e)
        {
            Variables.strJsDosArchiveOutputPath = tbJsDosArchiveOutputPath.Text;
            groupBox4.Enabled = true;
        }

        private void tbDosGameFileDirectory_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox5.Enabled = true;

            string[] __strArrFiles = Directory.GetFiles(tbDosGameFileDirectory.Text);
            lbDosGameFiles.Items.Clear();

            for (int ___intIndex = 0; ___intIndex < __strArrFiles.Length; ___intIndex++)
            {
                if(!Variables.strArrIgnoredExtensions.Contains(Path.GetExtension(__strArrFiles[___intIndex])))
                    lbDosGameFiles.Items.Add(__strArrFiles[___intIndex].ToString());
            }

        }

        private void btnCustomizeStartBatchFile_Click(object sender, EventArgs e)
        {
            if (Variables.strDosGameStartBatchFile == string.Empty)
            {
                Form _frmEditor = new Form2(Variables.strDefDosGameStartBatchFile, "start_batch");
                _frmEditor.ShowDialog();
            }
            else
            {
                Form _frmEditor = new Form2(Variables.strDosGameStartBatchFile, "start_batch");
                _frmEditor.ShowDialog();
            }
        }

        private void tbDosGameExecutable_TextChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
