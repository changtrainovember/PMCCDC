using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Models.SYSTEM
{
    public class SystemGroupReportViewModel
    {
        public string ReportID { get; set; }
        public string ReportName { get; set; }
        public string ParentID { get; set; }
        public string ModuleID { get; set; }
        public bool IsActive { get; set; }
    }
    public class SystemGroupReportConfig
    {
        public int GroupID { get; set; }
        public string ReportID { get; set; }
        public bool IsActive { get; set; }
    }
}