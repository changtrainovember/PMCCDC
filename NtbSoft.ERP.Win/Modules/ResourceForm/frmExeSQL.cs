using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using NtbSoft.ERP.Win.Service.SYSTEM;
using NtbSoft.ERP.Entity.SYSTEM;
using NtbSoft.ERP.Win.Utils;

namespace NtbSoft.ERP.Win.Modules.ResourceForm
{
    public partial class frmExeSQL : DevExpress.XtraEditors.XtraForm
    {
        System.Configuration.AppSettingsReader settingsReader =
                                         new System.Configuration.AppSettingsReader();
        string URL = string.Empty;
        SystemLogService _serviceLog;
        public frmExeSQL()
        {
            InitializeComponent();
            URL = (string)settingsReader.GetValue("URL", typeof(String));
            _serviceLog = new SystemLogService();
        }

        private void btChoseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Sfd = new OpenFileDialog();
            Sfd.Title = "Choose file";
            Sfd.Filter = "SQL (*.sql)|*.sql";

            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                string script = File.ReadAllText(Sfd.FileName);
                tbSQL.Text = script;
            }
        }

        private void btExeSQL_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbSQL.Text))
            {
                XtraMessageBox.Show("Hãy chọn file!", Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SystemLogExeSQLEntity exeObj = new SystemLogExeSQLEntity();
            exeObj.ID = 1;
            exeObj.Content = tbSQL.Text;

            string urlExe = string.Format("{0}/ExeSql", URL + ResourceURL.UrlSystemLog);
            string ms = Task.Run(async () => { return await _serviceLog.ExeSql(exeObj, urlExe); }).Result;

            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(ms, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                clsWaitForm.ShowSuccessForm(this, 3000);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbSQL.Text = "";    
        }
    }
}