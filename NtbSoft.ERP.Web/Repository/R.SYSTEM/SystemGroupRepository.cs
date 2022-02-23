using NtbSoft.ERP.Model.SYSTEM;
using NtbSoft.ERP.Api.Repository.Interface.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Repository.R.SYSTEM
{
    public class SystemGroupRepository : ISystemGroupRepository
    {
        SystemGroupModel _model;
        public SystemGroupRepository()
        {
            _model = new SystemGroupModel();
        }
        public List<Models.SYSTEM.SystemGroupViewModel> Get()
        {
            DataTable tb = _model.Get();
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemGroupViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemGroupViewModel>();
            return convert.ToList(tb);
        }

        public string Post(Models.SYSTEM.SystemGroupViewModel item)
        {
            List<Models.SYSTEM.SystemGroupViewModel> list = new List<Models.SYSTEM.SystemGroupViewModel>();
            list.Add(item);
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemGroupViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemGroupViewModel>();
            return _model.Post(convert.ToDataTable(list));
        }

        public string Delete(int id)
        {
            return _model.Delete(id);
        }
    }
}