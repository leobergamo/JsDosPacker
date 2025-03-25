using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JsDosPacker
{

    public partial class Form2 : Form
    {
        private string strContext;

        public Form2(string _strOriginalString, string _strContext)
        {
            InitializeComponent();

            this.strContext = _strContext;

            tbEditor.AppendText(Utilities.strTrimStartMultiLineString(_strOriginalString));
        }

        private void btnOk_Click(object _objSender, EventArgs _eaEventArgs)
        {
            if (this.strContext == "dosbox_conf")
            {
                Variables.strDosBoxConf = tbEditor.Text;
            }
            else if (this.strContext == "jsdos_json")
            {
                Variables.strJsDosJson = tbEditor.Text;
            }
            else if (this.strContext == "start_batch")
            {
                Variables.strDosGameStartBatchFile = tbEditor.Text;
            }

            this.Close();
        }

        private void btnCancel_Click(object _objSender, EventArgs _eaEventArgs)
        {
            this.Close();
        }

        private void btnReset_Click(object _objSender, EventArgs _eaEventArgs)
        {
            if (this.strContext == "dosbox_conf")
            {
                tbEditor.Text = Utilities.strTrimStartMultiLineString(Variables.strDefDosBoxConf);
            }
            else if (this.strContext == "jsdos_json")
            {
                tbEditor.Text = Utilities.strTrimStartMultiLineString(Variables.strDefJsDosJson);
            }
            else if (this.strContext == "start_batch")
            {
                tbEditor.Text = Utilities.strTrimStartMultiLineString(Variables.strDefDosGameStartBatchFile);
            }

        }
    }
}
