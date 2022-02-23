using NtbSoft.ERP.Api.Models.SYSTEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtbSoft.ERP.Api.Repository.Interface.SYSTEM
{
    public interface ISystemUserModuleRepository
    {
        List<SystemUserModuleViewModel> Get(string userID);
        List<SystemUserModuleViewModel> GetPermission(string userID);
        string Post(List<SystemUserModuleConfig> items);
    }
}
