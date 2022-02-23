using NtbSoft.ERP.Web.Filter;
using NtbSoft.ERP.Web.Repository.R.THIETBI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NtbSoft.ERP.Web.Api.THIETBI
{
    [HMACAuthentication]
    [RoutePrefix("api/LinhKien")]
    public class LinhKienController : ApiController
    {
        ILinhKienRepository _repo = new LinhKienRepository();

        [HttpGet]
        [Route("GetDSLinhKien")]
        public DataTable GetDSLinhKien()
        {
            return _repo.GetDSLinhKien();
        }

        [HttpPost]
        [Route("PostLinhKien")]
        public string PostLinhKien(string action, object lstSave)
        {
            return _repo.PostLinhKien(action, lstSave);
        }

        [HttpDelete]
        [Route("DeleteLinhKien")]
        public string DeleteLinhKien(int ID)
        {
            return _repo.DeleteLinhKien(ID);
        }
    }
}
