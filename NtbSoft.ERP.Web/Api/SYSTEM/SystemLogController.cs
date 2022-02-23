using NtbSoft.ERP.Web.Filter;
using NtbSoft.ERP.Web.Models.SYSTEM;
using NtbSoft.ERP.Web.Repository.R.SYSTEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NtbSoft.ERP.Web.Api.SYSTEM
{
    [HMACAuthentication]
    [RoutePrefix("api/SystemLog")]
    public class SystemLogController : ApiController
    {
        ISystemLogRepository _repo = new SystemLogRepository();

        [HttpGet]
        [Route("Get")]
        public IEnumerable<SystemLogViewModel> Get(string fromStr,string toStr)
        {
            DateTime fromDate = Convert.ToDateTime(fromStr);
            DateTime toDate = Convert.ToDateTime(toStr);
            return _repo.Get(fromDate,toDate);
        }
        [HttpPost]
        [Route("")]
        public string Post(List<SystemLogConfig> items)
        {
            return _repo.Post(items);
        }
        [HttpPost]
        [Route("ExeSql")]
        public string ExeSql(SystemLogExeSQLViewModel items)
        {
            return _repo.ExeSQL(items);
        }

        [HttpDelete]
        [Route("{id}")]
        public string Delete(long id)
        {
            return _repo.Delete(id);
        }
    }
}
