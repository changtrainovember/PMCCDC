using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Web.Models.SYSTEM
{
    public class SystemLogViewModel : SystemLogConfig
    {
        
    }
    public class SystemLogConfig
    {
        public long ID { get; set; }
        public string MChine { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModuleName { get; set; }
        public string Action { get; set; }
        public string UserName { get; set; }
        public int Value { get; set; }
        public string Mota { get; set; }
        public string IPLan { get; set; }
        public string IPWan { get; set; }
    }
    public class SystemLogExeSQLViewModel
    {
        public int ID { get; set; }
        public string Content { get;set; }
    }
}