using NtbSoft.ERP.Api.Models.SYSTEM;
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
    [RoutePrefix("api/SystemDepartment")]
    public class SystemDepartmentController : ApiController
    {
        ISystemDepartmentRepository _repo = new SystemDepartmentRepository();

        [HttpGet]
        [Route("Get")]
        public List<SystemDepartmentViewModel> Get()
        {
            return _repo.Get();
        }
        [HttpPost]
        [Route("")]
        public string Post(List<SystemDepartmentViewModel> item)
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
