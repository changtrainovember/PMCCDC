using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Models.SYSTEM
{
    public class SystemUserReportViewModel : SystemUserReportConfig
    {
        public string ReportName { get; set; }
        public string ParentID { get; set; }
        public string ModuleID { get; set; }
        public string FormShow { get; set; }
    }
    public class SystemUserReportConfig
    {
        public string UserID { get; set; }
        public string ReportID { get; set; }
        public bool IsActive { get; set; }
    }
}