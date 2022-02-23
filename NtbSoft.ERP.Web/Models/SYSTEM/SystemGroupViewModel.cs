using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Models.SYSTEM
{
    public class SystemGroupViewModel
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string Descriptions { get; set; }
        public bool Active { get; set; }
    }
}