using NtbSoft.ERP.Model.SYSTEM;
using NtbSoft.ERP.Api.Repository.Interface.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Repository.R.SYSTEM
{
    public class SystemGroupModuleRepository : ISystemGroupModuleRepository
    {
        SystemGroupModuleModel _model;
        public SystemGroupModuleRepository()
        {
            _model = new SystemGroupModuleModel();
        }
        public List<Models.SYSTEM.SystemGroupModuleViewModel> Get(int groupId)
        {
            DataTable tb = _model.Get(groupId);
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemGroupModuleViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemGroupModuleViewModel>();
            return convert.ToList(tb);
        }

        public string Post(List<Models.SYSTEM.SystemGroupModuleConfig> items)
        {
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemGroupModuleConfig> convert = new Libs.clsConvert<Models.SYSTEM.SystemGroupModuleConfig>();
            return _model.Post(convert.ToDataTable(items));
        }
    }
}