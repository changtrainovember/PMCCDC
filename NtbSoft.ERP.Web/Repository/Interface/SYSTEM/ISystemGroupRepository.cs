using NtbSoft.ERP.Api.Models.SYSTEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtbSoft.ERP.Api.Repository.Interface.SYSTEM
{
    public interface ISystemGroupRepository
    {
        List<SystemGroupViewModel> Get();
        string Post(SystemGroupViewModel item);
        string Delete(int id);
    }
}
