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
using NtbSoft.ERP.Win.Service.SYSTEM;
using NtbSoft.ERP.Win.Utils;
using NtbSoft.ERP.Entity.SYSTEM;
using NtbSoft.ERP.Win.Modules.ResourceForm;

namespace NtbSoft.ERP.Win.Modules.SystemForm
{
    public partial class frmSysLog : DevExpress.XtraEditors.XtraForm
    {
        System.Configuration.AppSettingsReader settingsReader =
                                           new System.Configuration.AppSettingsReader();
        string URL = string.Empty;
        bool _allowAdd = false, _allowEdit = false, _allowDelete = false;

        SystemLogService _serviceLog;
        SystemUserModuleService _serviceUserModule;

        public frmSysLog()
        {
            InitializeComponent();
            URL = (string)settingsReader.GetValue("URL", typeof(String));
            _serviceLog = new SystemLogService();
            _serviceUserModule = new SystemUserModuleService();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CheckPerminsion();
            CreateDefaultData();
            LoadData();

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

            if (!_allowAdd || !_allowEdit)
                btExeSQL.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            
        }
        

        private void LoadData()
        {
            if (barEditItemFromDate.EditValue == null)
                return;
            if (barEditItemToDate.EditValue == null)
                return;
            DateTime fromDate = Convert.ToDateTime(barEditItemFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(barEditItemToDate.EditValue);

            string urlGet = string.Format("{0}/Get?fromStr={1}&&toStr={2}", URL + ResourceURL.UrlSystemLog, fromDate.ToString("MM-dd-yyyy"), toDate.ToString("MM-dd-yyyy"));
            List<SystemLogEntity> listLog = Task.Run(async()=>{return await _serviceLog.LogGet(urlGet);}).Result;
            gridControl1.DataSource = listLog;

        }

        private void CreateDefaultData()
        {
            DateTime nextDate = DateTime.Now.AddDays(1);
            barEditItemFromDate.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0, 0);
            barEditItemToDate.EditValue = nextDate;
        }

        private void btFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btExeSQL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmExeSQL frm = new frmExeSQL();
            frm.ShowDialog();
        }
    }
}