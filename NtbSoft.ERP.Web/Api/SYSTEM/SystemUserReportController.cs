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
    [RoutePrefix("api/SystemUserReport")]
    public class SystemUserReportController : ApiController
    {
        ISystemUserReportRepository _repo = new SystemUserReportRepository();
       
        [HttpGet]
        [Route("Get")]
        public List<SystemUserReportViewModel> Get(string userID)
        {
            return _repo.Get(userID);
        }
        [HttpGet]
        [Route("GetPer")]
        public List<SystemUserReportViewModel> GetPer(string userID)
        {
            return _repo.GetPer(userID);
        }

        [HttpPost]
        [Route("")]
        public string Post(List<SystemUserReportConfig> items)
        {
            return _repo.Post(items);
        }
    }
}
