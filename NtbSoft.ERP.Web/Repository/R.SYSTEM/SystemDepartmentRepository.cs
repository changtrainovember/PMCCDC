using NtbSoft.ERP.Api.Models.SYSTEM;
using NtbSoft.ERP.Model.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Repository.R.SYSTEM
{
    public interface ISystemDepartmentRepository
    {
        List<SystemDepartmentViewModel> Get();
        string Post(List<SystemDepartmentViewModel> items);
        string Delete(string id);
    }
    public class SystemDepartmentRepository : ISystemDepartmentRepository
    {
        SystemDepartmentModel _model;
        public SystemDepartmentRepository()
        {
            _model = new SystemDepartmentModel();
        }
        public List<SystemDepartmentViewModel> Get()
        {
            DataTable tb = _model.Get();
            NtbSoft.ERP.Libs.clsConvert<SystemDepartmentViewModel> convert = new Libs.clsConvert<SystemDepartmentViewModel>();
            return convert.ToList(tb);
        }

        public string Post(List<SystemDepartmentViewModel> items)
        {
            NtbSoft.ERP.Libs.clsConvert<SystemDepartmentViewModel> convert = new Libs.clsConvert<SystemDepartmentViewModel>();
            return _model.Post(convert.ToDataTable(items));
        }

        public string Delete(string id)
        {
            return _model.Delete(id);
        }
    }
}