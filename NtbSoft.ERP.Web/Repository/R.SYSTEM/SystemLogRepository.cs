using NtbSoft.ERP.Model.SYSTEM;
using NtbSoft.ERP.Web.Models.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Web.Repository.R.SYSTEM
{
    public interface ISystemLogRepository
    {
        List<SystemLogViewModel> Get(DateTime fromDate, DateTime toDate);
        string ExeSQL(SystemLogExeSQLViewModel items);
        string Post(List<SystemLogConfig> items);
        string Delete(long id);
    }
    public class SystemLogRepository : ISystemLogRepository
    {
        private readonly SystemLogModel _model;
        public SystemLogRepository()
        {
            _model = new SystemLogModel();
        }
        public List<SystemLogViewModel> Get(DateTime fromDate, DateTime toDate)
        {
            DataTable tb = _model.Get(fromDate, toDate);
            NtbSoft.ERP.Libs.clsConvert<SystemLogViewModel> convert = new Libs.clsConvert<SystemLogViewModel>();
            return convert.ToList(tb);
        }

        public string Post(List<SystemLogConfig> items)
        {
            NtbSoft.ERP.Libs.clsConvert<SystemLogConfig> convert = new Libs.clsConvert<SystemLogConfig>();
            return _model.Post(convert.ToDataTable(items));
        }

        public string Delete(long id)
        {
            return _model.Delete(id);
        }


        public string ExeSQL(SystemLogExeSQLViewModel items)
        {
           
            return _model.ExeSQL(items.Content);
        }
    }
}