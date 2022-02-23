using NtbSoft.ERP.Api.Models.SYSTEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtbSoft.ERP.Api.Repository.Interface.SYSTEM
{
    public interface ISystemUserReportRepository
    {
        List<SystemUserReportViewModel> Get(string userID);
        List<SystemUserReportViewModel> GetPer(string userID);
        string Post(List<SystemUserReportConfig> items);
    }
}
