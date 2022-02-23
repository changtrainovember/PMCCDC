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
    [RoutePrefix("api/SystemUser")]
    public class SystemUserController : ApiController
    {
        ISystemUserRepository _repo = new SystemUserRepository();
        
        [HttpGet]
        [Route("Get")]
        public IEnumerable<SystemUserViewModel> Get()
        {
            return _repo.Get();
        }
        [HttpPost]
        [Route("")]
        public string Post(SystemUserViewModel item)
        {
            return _repo.Post(item);
        }
        [HttpDelete]
        [Route("{id}")]
        public string Delete(string id)
        {
            return _repo.Delete(id);
        }
    }
}
