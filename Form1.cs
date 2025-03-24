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
            Strings.strDosGameFilePath = dlgSelectFolder.SelectedPath;

        }

        private void btnChooseJsDosOutputDirectory_Click(object _objSender, EventArgs _eaEventArgs)
        {
            dlgSelectFolder.InitialDirectory = "c:\\";
            dlgSelectFolder.ShowDialog();
            tbJsDosArchiveOutputPath.Text = dlgSelectFolder.SelectedPath;
            Strings.strJsDosArchiveOutputPath = dlgSelectFolder.SelectedPath;
        }

        private void btnCustomizeDosBoxConf_Click(object _objSender, EventArgs _eaEventArgs)
        {
            if (Strings.strDosBoxConf == string.Empty)
            {
                Form _frmEditor = new Form2(Strings.strDefDosBoxConf, "dosbox_conf");
                _frmEditor.ShowDialog();
            }
            else
            {
                Form _frmEditor = new Form2(Strings.strDosBoxConf, "dosbox_conf");
                _frmEditor.ShowDialog();
            }
        }

        private void btnCustomizeJsDosJson_Click(object _objSender, EventArgs _eaEventArgs)
        {
            if (Strings.strJsDosJson == string.Empty)
            {
                Form _frmEditor = new Form2(Strings.strDefJsDosJson, "jsdos_json");
                _frmEditor.ShowDialog();
            }
            else
            {
                Form _frmEditor = new Form2(Strings.strJsDosJson, "jsdos_json");
                _frmEditor.ShowDialog();
            }
        }

        private void btnCreatePackage_Click(object _objSender, EventArgs _eaEventArgs)
        {


            if (Strings.strDosBoxConf == string.Empty)
            {
                MessageBox.Show("DosBox configuration not defined!");
                return;
            }

            if (Strings.strDosGameExecutablePath == string.Empty)
            {
                MessageBox.Show("DOS game executable path not defined!");
                return;
            }

            if (Strings.strDosGameFilePath == string.Empty)
            {
                MessageBox.Show("DOS game file directory not defined!");
                return;
            }

            if (Strings.strDosGameStartBatchFile == string.Empty)
            {
                MessageBox.Show("DOS game start batch file not defined!");
                return;
            }

            if (Strings.strJsDosArchiveName == string.Empty)
            {
                MessageBox.Show("JsDos archive name not defined!");
                return;
            }

            if (Strings.strJsDosArchiveOutputPath == string.Empty)
            {
                MessageBox.Show("JsDos archive output path not defined!");
                return;
            }

            if (Strings.strJsDosJson == string.Empty)
            {
                MessageBox.Show("JsDos json not defined!");
                return;
            }

            try
            {
                string _strTempBundlePath = Directory.CreateTempSubdirectory().FullName;
                string _strTempBundleJsDosPath = Directory.CreateDirectory(Path.Combine(_strTempBundlePath, ".jsdos")).FullName;
                string _strJsDosOutputArchiveFilespec = Path.Combine(Strings.strJsDosArchiveOutputPath, "jsdos_bundle_" + Strings.strJsDosArchiveName + ".jsdos");

                lbLog.Items.Add("Creating bundle, please wait...");
                lbLog.Items.Add("Using temporary directory: '" + _strTempBundlePath + "'...");
                /*if (File.Exists(_strJsDosOutputArchiveFilespec))
                {
                    lbLog.Items.Add("Found old bundle: '" + _strJsDosOutputArchiveFilespec + "'...");
                    lbLog.Items.Add("Deleting old bundle...");
                    File.Delete(_strJsDosOutputArchiveFilespec);
                }*/
                lbLog.Items.Add("Copying file(s) to temporary directory...");
                foreach (string __strFilePath in lbDosGameFiles.Items)
                {
                    lbLog.Items.Add("Copying file: '" + __strFilePath + "'...");
                    File.Copy(__strFilePath, Path.Combine(_strTempBundlePath, Path.GetFileName(__strFilePath)), true);
                }

                lbLog.Items.Add("Creating and storing dosbox configuration in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundleJsDosPath, "dosbox.conf"), Utilities.trimStartMultiLineString(Strings.strDosBoxConf));
                lbLog.Items.Add("Creating and storing jsdos json in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundleJsDosPath, "jsdos.json"), Utilities.trimStartMultiLineString(Strings.strJsDosJson));
                lbLog.Items.Add("Creating and storing start batch file in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundlePath, "start.bat"), Utilities.trimStartMultiLineString(string.Format(Strings.strDosGameStartBatchFile, Path.GetFileName(Strings.strDosGameExecutablePath))));
                lbLog.Items.Add("Creating and storing bundle: '" + Path.GetFileName(_strJsDosOutputArchiveFilespec) + "' of temporary files in directory: '" + Path.GetDirectoryName(_strJsDosOutputArchiveFilespec) + "'...");
                ZipFile.CreateFromDirectory(_strTempBundlePath, _strJsDosOutputArchiveFilespec);
                lbLog.Items.Add("Removing temporary directory...");
                Utilities.deleteDirectory(_strTempBundlePath);
                lbLog.Items.Add("Bundle created!");
                lbLog.SelectedIndex = lbLog.Items.Count - 1;
                lbLog.SelectedIndex = -1;
            } catch (Exception _objExc)
            {
                lbLog.Items.Add("Bundle creation failed: '" + _objExc.Message + "'...");
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
            Strings.strDosGameExecutablePath = dlgSelectFile.FileName;
        }

        private void tbJsDosArchiveName_TextChanged(object _objSender, EventArgs _eaEventArgs)
        {
            Strings.strJsDosArchiveName = tbJsDosArchiveName.Text;
        }

        private void tbJsDosArchiveOutputPath_TextChanged(object sender, EventArgs e)
        {
            Strings.strJsDosArchiveOutputPath = tbJsDosArchiveOutputPath.Text;
            groupBox4.Enabled = true;
        }

        private void tbDosGameFileDirectory_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox5.Enabled = true;

            string[] __str_arr_files = Directory.GetFiles(tbDosGameFileDirectory.Text);
            lbDosGameFiles.Items.Clear();

            for (int ___intIndex = 0; ___intIndex < __str_arr_files.Length; ___intIndex++)
            {
                lbDosGameFiles.Items.Add(__str_arr_files[___intIndex].ToString());
            }

        }

        private void btnCustomizeStartBatchFile_Click(object sender, EventArgs e)
        {
            if (Strings.strDosGameStartBatchFile == string.Empty)
            {
                Form _frmEditor = new Form2(Strings.strDefDosGameStartBatchFile, "start_batch");
                _frmEditor.ShowDialog();
            }
            else
            {
                Form _frmEditor = new Form2(Strings.strDosGameStartBatchFile, "start_batch");
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
