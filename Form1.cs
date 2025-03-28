using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Security.Policy;
using System.Windows.Forms;

namespace JsDosPacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void vAddToLog(string _strMessage)
        {
            DateTime _objDateTime = DateTime.Now;
            string _strTimeStamp = _objDateTime.ToString("yyyy-MM-dd HH:mm");
            lbLog.Items.Add(_strTimeStamp + ": " + _strMessage);
            lbLog.SelectedIndex = lbLog.Items.Count - 1;
            lbLog.SelectedIndex = -1;
        }

        private void btnChooseDosGameFileDirectory_Click(object _objSender, EventArgs _eaEventArgs)
        {

            dlgSelectFolder.InitialDirectory = "c:\\";
            dlgSelectFolder.ShowDialog();
            tbDosGameFileDirectory.Text = dlgSelectFolder.SelectedPath;
            tbJsDosArchiveOutputPath.Text = dlgSelectFolder.SelectedPath;
            tbJsDosArchiveName.Text = Path.GetFileName(dlgSelectFolder.SelectedPath);
            Variables.strDosGameFilePath = dlgSelectFolder.SelectedPath;
            vAddToLog("Game file directory '" + Variables.strDosGameFilePath + "' selected...");
        }

        private void btnChooseJsDosOutputDirectory_Click(object _objSender, EventArgs _eaEventArgs)
        {
            dlgSelectFolder.InitialDirectory = "c:\\";
            dlgSelectFolder.ShowDialog();
            tbJsDosArchiveOutputPath.Text = dlgSelectFolder.SelectedPath;
            Variables.strJsDosArchiveOutputPath = dlgSelectFolder.SelectedPath;
            vAddToLog("JsDos output directory '" + Variables.strJsDosArchiveOutputPath + "' selected...");
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

                vAddToLog("Creating JsDos bundle, please wait...");
                vAddToLog("Using temporary directory: '" + _strTempBundlePath + "'...");
                if (File.Exists(_strJsDosOutputArchiveFilespec))
                {
                    vAddToLog("Found old bundle: '" + _strJsDosOutputArchiveFilespec + "'...");
                    vAddToLog("Deleting old bundle...");
                    File.Delete(_strJsDosOutputArchiveFilespec);
                }
                vAddToLog("Copying game file(s) to temporary directory...");
                Utilities.vCopyRecursively(Variables.strDosGameFilePath, _strTempBundlePath, this.vAddToLog);

                vAddToLog("Creating then storing dosbox configuration in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundleJsDosPath, "dosbox.conf"), Utilities.strTrimStartMultiLineString(Variables.strDosBoxConf));
                vAddToLog("Creating then storing jsdos json in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundleJsDosPath, "jsdos.json"), Utilities.strTrimStartMultiLineString(Variables.strJsDosJson));
                vAddToLog("Creating then storing start batch file in temproary directory...");
                File.WriteAllText(Path.Combine(_strTempBundlePath, "start.bat"), Utilities.strTrimStartMultiLineString(string.Format(Variables.strDosGameStartBatchFile, Path.GetFileName(Variables.strDosGameExecutablePath))));
                vAddToLog("Creating then storing '" + Path.GetFileName(_strJsDosOutputArchiveFilespec) + "' bundle in directory: '" + Path.GetDirectoryName(_strJsDosOutputArchiveFilespec) + "'...");
                ZipFile.CreateFromDirectory(_strTempBundlePath, _strJsDosOutputArchiveFilespec);
                vAddToLog("Removing temporary directory...");
                Utilities.vDeleteDirectory(_strTempBundlePath);
                vAddToLog("Bundle created!");
                Process.Start("explorer.exe", @Path.GetDirectoryName(_strJsDosOutputArchiveFilespec));
            }
            catch (Exception _objExc)
            {
                vAddToLog("Bundle creation failed: '" + _objExc.Message + "'...");
                Utilities.vConLog(_objExc.ToString());
            }
        }

        private void btnChooseDosGameExecutable_Click(object _objSender, EventArgs _eaEventArgs)
        {
            dlgSelectFile.Title = "Choose DOS Game Startup File";
            dlgSelectFile.Filter = "Executable Files (*.exe)|*.exe|Command Files (*.com)|*.com|Batch Files (*.bat)|*.bat";
            dlgSelectFile.InitialDirectory = tbDosGameFileDirectory.Text;
            dlgSelectFile.FileName = "";
            dlgSelectFile.ShowDialog();
            tbDosGameExecutable.Text = dlgSelectFile.FileName;
            Variables.strDosGameExecutablePath = dlgSelectFile.FileName;
            vAddToLog("Game executable file '" + Variables.strDosGameExecutablePath + "' selected...");

        }

        private void tbJsDosArchiveName_TextChanged(object _objSender, EventArgs _eaEventArgs)
        {
            Variables.strJsDosArchiveName = tbJsDosArchiveName.Text;
            Utilities.vAsyncFlashControl(tbJsDosArchiveName);
        }

        private void tbJsDosArchiveOutputPath_TextChanged(object sender, EventArgs e)
        {
            Variables.strJsDosArchiveOutputPath = tbJsDosArchiveOutputPath.Text;
            groupBox4.Enabled = true;
            Utilities.vAsyncFlashControl(tbJsDosArchiveName);
        }

        private void tbDosGameFileDirectory_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox5.Enabled = true;

            lbDosGameFiles.Items.Clear();

            string[] __strArrFiles = Directory.GetFiles(tbDosGameFileDirectory.Text, "*", SearchOption.AllDirectories);

            for (int ___intIndex = 0; ___intIndex < __strArrFiles.Length; ___intIndex++)
            {
                if (!Variables.strArrIgnoredExtensions.Contains(Path.GetExtension(__strArrFiles[___intIndex])))
                {
                    vAddToLog("Found game file '" + __strArrFiles[___intIndex] + "' found...");
                    lbDosGameFiles.Items.Add(__strArrFiles[___intIndex]);
                }
            }

            Utilities.vAsyncFlashControl(tbDosGameExecutable);

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
            Utilities.vAsyncFlashControl(tbJsDosArchiveOutputPath);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://js-dos.com/overview.html", UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://discord.com/invite/hMVYEbG", UseShellExecute = true });

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://dos.zone/", UseShellExecute = true });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://x.com/intent/user?screen_name=doszone_db", UseShellExecute = true });

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://js-dos.com/support-us.html", UseShellExecute = true });

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://dos.zone/studio/", UseShellExecute = true });
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://dos.zone/download/", UseShellExecute = true });

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/leobergamo/JsDosPacker.git", UseShellExecute = true });

        }
    }
}
