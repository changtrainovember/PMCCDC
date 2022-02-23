using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using NtbSoft.ERP.Entity.THIETBI;
using NtbSoft.ERP.Win.Modules.ResourceForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtbSoft.ERP.Win.Modules.LinhKienForm
{
    public partial class frmDsLinhKien : DevExpress.XtraEditors.XtraForm
    {
        HttpClientExtension _clientExtension = new HttpClientExtension();
        System.Configuration.AppSettingsReader settingsReader =
                                               new System.Configuration.AppSettingsReader();
        string URL = string.Empty;
        int _id = 0;
        DataTable _tbl = new DataTable();
        List<LinhKienEntity> _lstSave = new List<LinhKienEntity>();
        public frmDsLinhKien()
        {
            InitializeComponent();
            URL = (string)settingsReader.GetValue("URL", typeof(String));
            LoadDSLinhKien();
            
        }

        private void LoadDSLinhKien()
        {
            string url = string.Format("{0}", URL + "/LinhKien/GetDSLinhKien");
            string json = Task.Run(async () => { return await _clientExtension.GetAsnyc(url); }).Result;
            _tbl = JsonConvert.DeserializeObject<DataTable>(json);
            if (_tbl.Columns.Count == 0) CreateDatatable();
            dgrDsLinhKien.DataSource = _tbl;
        }

        private int GetFocusRowHandel()
        {
            int focusRowHandel = gridViewLinhKien.FocusedRowHandle;
            if (focusRowHandel == null || focusRowHandel < 0) return -1;
            return focusRowHandel;
        }

        private void ReloadData()
        {
            try
            {
                int focusRowHandel = GetFocusRowHandel();
                LoadDSLinhKien();
                if (focusRowHandel != 0)
                    gridViewLinhKien.FocusedRowHandle = focusRowHandel;
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void CreateDatatable()
        {
            _tbl = new DataTable();
            _tbl.Columns.Add("ID", typeof(int));
            _tbl.Columns.Add("MaLK", typeof(string));
            _tbl.Columns.Add("TenLK", typeof(string));
            _tbl.Columns.Add("SoLuong", typeof(int));
            _tbl.Columns.Add("GhiChu", typeof(string));
        }

        private void gridViewLinhKien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                DataRow drFocus = gridViewLinhKien.GetFocusedDataRow();
                if (drFocus == null) return;
                if (drFocus["ID"].ToString() == "") drFocus["ID"] = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable tbl = dgrDsLinhKien.DataSource as DataTable;
            string json = JsonConvert.SerializeObject(tbl);
            _lstSave = new List<LinhKienEntity>();
            _lstSave = JsonConvert.DeserializeObject<List<LinhKienEntity>>(json);
            string url = string.Format("{0}?action={1}", URL + "LinhKien/PostLinhKien", "InsertOrUpdate");
            string result = Task.Run(async () => { return await _clientExtension.PostAsync(url, _lstSave); }).Result;
            if (result.ToLower() == "true")
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(frmExcSuccess));
                ReloadData();
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
            }
        }

        private void gridViewLinhKien_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            object val = e.Value;

            if (view.FocusedColumn.FieldName == "MaLK" && val != null)
            {
                DataRow drCheck = _tbl.AsEnumerable().Where(x => x["MaLK"].ToString() == val.ToString()).FirstOrDefault();
                if (drCheck != null)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã linh kiện đã tồn tại!!!";
                }
            }
        }

        private void btCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(frmWait));
            ReloadData();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
        }
        
        private void btDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow drFocus = gridViewLinhKien.GetFocusedDataRow();
            if (drFocus == null) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                int ID = Convert.ToInt32(drFocus["ID"]);
                string url = string.Format("{0}?ID={1}", URL + "LinhKien/DeleteLinhKien", ID);
                string result = Task.Run(async () => { return await _clientExtension.DeletedAsync(url); }).Result;
                if (result.ToLower() == "true")
                {
                    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(frmExcSuccess));
                    ReloadData();
                    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
                }
            }
        }
    }
}
