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
using NtbSoft.ERP.Entity.SYSTEM;
using NtbSoft.ERP.Win.Service.SYSTEM;
using NtbSoft.ERP.Win.Utils;
using NtbSoft.ERP.Win.Modules.SystemForm;



namespace NtbSoft.ERP.Win.Modules.DicForm
{
    public partial class frmDicInitialize : DevExpress.XtraEditors.XtraForm
    {
        bool _allowAdd = false, _allowEdit = false, _allowDelete = false;
        SystemUserModuleService _serviceUserModule;
        System.Configuration.AppSettingsReader settingsReader =
                                              new System.Configuration.AppSettingsReader();
        string URL = string.Empty;

        public frmDicInitialize()
        {
            InitializeComponent();
            _serviceUserModule = new SystemUserModuleService();
            URL = (string)settingsReader.GetValue("URL", typeof(String));
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CheckPerminsion();
            //CreateFormData();
        }

        private void CreateFormData()
        {
            
        }

        private void CheckPerminsion()
        {
            string url = string.Format("{0}/GetPer?userID={1}", URL + ResourceURL.UrlUserModule, GlobleData.UserName);
            List<SystemUserModuleEntity> List = Task.Run(async () => { return await _serviceUserModule.UserModuleGet(url); }).Result;
            SystemUserModuleEntity obj = (from m in List
                                          where m.FormShow == this.Name
                                          select m).FirstOrDefault();
            if (obj == null) return;
            _allowAdd = obj.AllowAdd;
            _allowEdit = obj.AllowEdit;
            _allowDelete = obj.AllowDelete;
        }

      
    }
}