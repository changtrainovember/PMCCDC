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
    [RoutePrefix("api/SystemGroupModule")]
    public class SystemGroupModuleController : ApiController
    {
        ISystemGroupModuleRepository _repo = new SystemGroupModuleRepository();
       
        [HttpGet]
        [Route("Get")]
        public List<SystemGroupModuleViewModel> Get(int groupId)
        {
            return _repo.Get(groupId);
        }
        [HttpPost]
        [Route("")]
        public string Post(List<SystemGroupModuleConfig> items)
        {
            return _repo.Post(items);
        }

    }
}
