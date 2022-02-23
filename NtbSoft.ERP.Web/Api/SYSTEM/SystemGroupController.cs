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
    [RoutePrefix("api/SystemGroup")]
    public class SystemGroupController : ApiController
    {
        ISystemGroupRepository _repo = new SystemGroupRepository();

        [HttpGet]
        [Route("Get")]
        public List<SystemGroupViewModel> Get()
        {
            return _repo.Get();
        }
        [HttpPost]
        [Route("")]
        public string Post(SystemGroupViewModel item)
        {
            return _repo.Post(item);
        }
        [HttpDelete]
        [Route("{id}")]
        public string Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
