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
using System.Configuration;
using NtbSoft.ERP.Entity.SYSTEM;
using NtbSoft.ERP.Win.Service.SYSTEM;
using NtbSoft.ERP.Win.Utils;

namespace NtbSoft.ERP.Win.Modules.SystemForm
{
    public partial class frmSysUserConfig : DevExpress.XtraEditors.XtraForm
    {
        System.Configuration.AppSettingsReader settingsReader =
                                               new AppSettingsReader();
        string URL = string.Empty;
        SystemUserService _serviceUser;
        public frmSysUserConfig()
        {
            InitializeComponent();
            URL = (string)settingsReader.GetValue("URL", typeof(String));
            _serviceUser = new SystemUserService();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

      

        private async void btSave_Click(object sender, EventArgs e)
        {
            if(string.Compare(tbPassword.Text,tbConfirmPassword.Text)!=0)
            {
                XtraMessageBox.Show(Properties.Resources.PasswordDonotMatch,Properties.Resources.InfoTitle,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(tbUserName.Text))
            {
                tbUserName.ErrorIconAlignment = ErrorIconAlignment.MiddleLeft;
                tbUserName.ErrorText = Properties.Resources.Required;
                return;
            }
            if(string.IsNullOrEmpty(tbPassword.Text))
            {
                tbPassword.ErrorIconAlignment = ErrorIconAlignment.MiddleLeft;
                tbPassword.ErrorText = Properties.Resources.Required;
                return;
            }
            SystemUserEntity sysUser = new SystemUserEntity();
            sysUser.Descriptions = memoEdit1.Text;
            if (searchLookUpEditEmployee.EditValue != null)
                sysUser.EmplyeeID = searchLookUpEditEmployee.EditValue.ToString();
            sysUser.AddDate = DateTime.Now;
         
            sysUser.IsAdmin = cbIsAdmin.Checked;
            sysUser.IsLock = cbIsLock.Checked;
            sysUser.LastView = DateTime.Now;
            NtbSoft.ERP.Libs.MD5Password md5Pass = new ERP.Libs.MD5Password();
            string newPass = md5Pass.Encrypt(tbPassword.Text, true);
            sysUser.Password = newPass;
            sysUser.UserName = tbUserName.Text;
            string ms = await _serviceUser.UpdateData(sysUser, URL + ResourceURL.UrlUser);
            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(ms, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();

        }

     
    }
}