using NtbSoft.ERP.Model.SYSTEM;
using NtbSoft.ERP.Api.Repository.Interface.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Repository.R.SYSTEM
{
    public class SystemGroupReportRepository : ISystemGroupReportRepository
    {
        public SystemGroupReportModel _model;
        public SystemGroupReportRepository()
        {
            _model = new SystemGroupReportModel();
        }
        public List<Models.SYSTEM.SystemGroupReportViewModel> Get(int groupId)
        {
            DataTable tb = _model.Get(groupId);
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemGroupReportViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemGroupReportViewModel>();
            return convert.ToList(tb);
        }

        public string Post(List<Models.SYSTEM.SystemGroupReportConfig> items)
        {
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemGroupReportConfig> convert = new Libs.clsConvert<Models.SYSTEM.SystemGroupReportConfig>();
            return _model.Post(convert.ToDataTable(items));
        }
    }
}