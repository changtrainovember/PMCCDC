using NtbSoft.ERP.Model.SYSTEM;
using NtbSoft.ERP.Api.Repository.Interface.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using NtbSoft.ERP.Api.Models.SYSTEM;

namespace NtbSoft.ERP.Api.Repository.R.SYSTEM
{
    public class SystemUserReportRepository : ISystemUserReportRepository
    {
        SystemUserReportModel _model;

        public SystemUserReportRepository()
        {
            _model = new SystemUserReportModel();
        }
        public List<Models.SYSTEM.SystemUserReportViewModel> Get(string userID)
        {
            DataTable tb = _model.GetAll(userID);
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemUserReportViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemUserReportViewModel>();
            return convert.ToList(tb);
        }
        public List<SystemUserReportViewModel> GetPer(string userID)
        {
            DataTable tb = _model.GetPer(userID);
            NtbSoft.ERP.Libs.clsConvert<SystemUserReportViewModel> convert = new Libs.clsConvert<SystemUserReportViewModel>();
            return convert.ToList(tb);
        }
        public string Post(List<Models.SYSTEM.SystemUserReportConfig> items)
        {
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemUserReportConfig> convert = new Libs.clsConvert<Models.SYSTEM.SystemUserReportConfig>();
            return _model.Post(convert.ToDataTable(items));
        }
    }
}