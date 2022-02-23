using NtbSoft.ERP.Api.Models.SYSTEM;
using NtbSoft.ERP.Api.Repository.Interface.SYSTEM;
using NtbSoft.ERP.Api.Repository.R.SYSTEM;
using NtbSoft.ERP.Web.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NtbSoft.ERP.Web.Api.SYSTEM
{
    [HMACAuthentication]
    [RoutePrefix("api/SystemGroupReport")]
    public class SystemGroupReportController : ApiController
    {
        ISystemGroupReportRepository _repo = new SystemGroupReportRepository();
      
        [HttpGet]
        [Route("Get")]
        public List<SystemGroupReportViewModel> Get(int groupId)
        {
            return _repo.Get(groupId);
        }
        [HttpPost]
        [Route("")]
        public string Post(List<SystemGroupReportConfig> items)
        {
            return _repo.Post(items);
        }
    }
}
