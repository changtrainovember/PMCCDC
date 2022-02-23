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
    [RoutePrefix("api/SystemUserModule")]
    public class SystemUserModuleController : ApiController
    {
        ISystemUserModuleRepository _repo = new SystemUserModuleRepository();
       
        [HttpGet]
        [Route("Get")]
        public IEnumerable<SystemUserModuleViewModel> Get(string userID)
        {
            return _repo.Get(userID);
        }
        [HttpGet]
        [Route("GetPer")]
        public IEnumerable<SystemUserModuleViewModel> GetPer(string userID)
        {
            return _repo.GetPermission(userID);
        }

        [HttpPost]
        [Route("")]
        public string Post(List<SystemUserModuleConfig> item)
        {
            return _repo.Post(item);
        }
    }
}
