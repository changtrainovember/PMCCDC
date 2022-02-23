using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NtbSoft.ERP.Api.Models.SYSTEM
{
    public class SystemDepartmentViewModel
    {
        public string DepID { get; set; }
        public string DepName { get; set; }
        public string ParentID { get; set; }
        public int Worker { get; set; }
        public string PhoneDep { get; set; }
        public bool IsChain { get; set; }
        public bool IsChainSaw { get; set; }
        public bool IsChainCut { get; set; }
        public bool IsChainPack { get; set; }
        public bool IsWarehouse { get; set; }
        public bool IsLocalDep { get; set; }
        public int Sort { get; set; }
    }
}