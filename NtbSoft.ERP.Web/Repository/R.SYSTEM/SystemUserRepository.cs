using NtbSoft.ERP.Model.SYSTEM;
using NtbSoft.ERP.Api.Repository.Interface.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Repository.R.SYSTEM
{
    public class SystemUserRepository : ISystemUserRepository
    {
        SystemUserModel _model;
        public SystemUserRepository()
        {
            _model = new SystemUserModel();
        }
        public List<Models.SYSTEM.SystemUserViewModel> Get()
        {
            DataTable tb = _model.GetAll();
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemUserViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemUserViewModel>();
            return convert.ToList(tb);
        }

        public string Post(Models.SYSTEM.SystemUserViewModel item)
        {
            List<Models.SYSTEM.SystemUserViewModel> list = new List<Models.SYSTEM.SystemUserViewModel>();
            list.Add(item);
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemUserViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemUserViewModel>();
            return _model.Post(convert.ToDataTable(list));
        }

        public string Delete(string id)
        {
            return _model.Delete(id);
        }



    }
}