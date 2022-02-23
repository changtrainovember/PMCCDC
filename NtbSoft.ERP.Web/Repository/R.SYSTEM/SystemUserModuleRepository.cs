using NtbSoft.ERP.Model.SYSTEM;
using NtbSoft.ERP.Api.Repository.Interface.SYSTEM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Repository.R.SYSTEM
{
    public class SystemUserModuleRepository : ISystemUserModuleRepository
    {
        SystemUserModuleModel _model;
        public SystemUserModuleRepository()
        {
            _model = new SystemUserModuleModel();
        }

        public List<Models.SYSTEM.SystemUserModuleViewModel> Get(string userID)
        {
            DataTable tb = _model.GetAll(userID);
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemUserModuleViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemUserModuleViewModel>();
            List<Models.SYSTEM.SystemUserModuleViewModel> list = convert.ToList(tb);
            //List<Models.SYSTEM.SystemUserModuleViewModel> listParent = (from l in list
            //                                                where l.ParentID == 0
            //                                                select l).ToList();
            //foreach (Models.SYSTEM.SystemUserModuleViewModel obj in listParent)
            //{
            //    obj.SubSystemModule = CreateChild(obj.ModuleID, list);
            //}

            return list;

        }
        private List<Models.SYSTEM.SystemUserModuleViewModel> CreateChild(string ModuleID, List<Models.SYSTEM.SystemUserModuleViewModel> list)
        {
            List<Models.SYSTEM.SystemUserModuleViewModel> listChilden = (from l in list
                                                             where l.ParentID == ModuleID
                                                             select l).ToList();
            //foreach (Models.SYSTEM.SystemUserModuleViewModel obj in listChilden)
            //{
            //    //obj.SubSystemModule = CreateChild(obj.ModuleID, list);
            //}
            return listChilden;
        }
        public string Post(List<Models.SYSTEM.SystemUserModuleConfig> items)
        {
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemUserModuleConfig> convert = new Libs.clsConvert<Models.SYSTEM.SystemUserModuleConfig>();
            return _model.Post(convert.ToDataTable(items));
        }


        public List<Models.SYSTEM.SystemUserModuleViewModel> GetPermission(string userID)
        {
            DataTable tb = _model.GetPer(userID);
            NtbSoft.ERP.Libs.clsConvert<Models.SYSTEM.SystemUserModuleViewModel> convert = new Libs.clsConvert<Models.SYSTEM.SystemUserModuleViewModel>();
            List<Models.SYSTEM.SystemUserModuleViewModel> list = convert.ToList(tb);
            return list;
        }
    }
}