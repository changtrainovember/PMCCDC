using Newtonsoft.Json;
using NtbSoft.ERP.Model.THIETBI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Web.Repository.R.THIETBI
{
    public interface ILinhKienRepository
    {
        DataTable GetDSLinhKien();
        string PostLinhKien(string action, object lstSave);
        string DeleteLinhKien(int ID);
    }
    public class LinhKienRepository : ILinhKienRepository
    {
        LinhKienModel _model = new LinhKienModel();
        public DataTable GetDSLinhKien()
        {
            DataTable tbl = _model.GetDSLinhKien();
            return tbl;
        }
        public string PostLinhKien(string action, object lstSave)
        {
            string json = JsonConvert.SerializeObject(lstSave);
            DataTable tblSave = JsonConvert.DeserializeObject<DataTable>(json);
            return _model.PostLinhKien(action, tblSave);
        }
        public string DeleteLinhKien(int ID)
        {
            return _model.DeleteLinhKien(ID);
        }
    }
}