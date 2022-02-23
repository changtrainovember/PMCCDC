using NtbSoft.ERP.Api.Models.SYSTEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtbSoft.ERP.Api.Repository.Interface.SYSTEM
{
    public interface ISystemGroupReportRepository
    {
        List<SystemGroupReportViewModel> Get(int groupId);
        string Post(List<SystemGroupReportConfig> items);
    }
}
