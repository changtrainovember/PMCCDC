using NtbSoft.ERP.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;

namespace NtbSoft.ERP.Web.Api.SYSTEM
{
    [RoutePrefix("api/SystemLogged")]
    public class SystemLoggedController : ApiController
    {
     
        Security _objSecurity;
        public SystemLoggedController()
        {
            _objSecurity = new Security();
        }
        [HttpGet]
        [Route("GetKey")]
        public string GetKey()
        {
            //string macAddr =
            //(
            //    from nic in NetworkInterface.GetAllNetworkInterfaces()
            //    where nic.OperationalStatus == OperationalStatus.Up
            //    select nic.GetPhysicalAddress().ToString()
            //).FirstOrDefault();
            var mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            var mbsList = mbs.Get();
            string macAddr = string.Empty;
            foreach (ManagementObject mo in mbsList)
            {
                macAddr = mo["ProcessorID"].ToString();
                //textBox1.Text = cpuid;
            }

            string _Path = _objSecurity.mRegKey + "\\" + _objSecurity.mSessionID.ToString("0000");
            object data = _objSecurity.get_RegistryKey(_Path, "ApiID");

            if (data != null)
            {
                _objSecurity.detele_RegistryKey(_Path, "ApiID");
            }
            _objSecurity.set_RegistryKey(_Path, "ApiID", macAddr);

            string rendomStr = CryptorEnginePro.GetRendomValue();
            string keySend = CryptorEnginePro.Encrypt(rendomStr + macAddr+"Server");//.Replace("/", "_");

            return keySend;
        }
        [HttpPost]
        [Route("SetKey")]
        public string SetKey(KeyActive keyObj)
        {
            string _Path = _objSecurity.mRegKey + "\\" + _objSecurity.mSessionID.ToString("0000");
            object data = _objSecurity.get_RegistryKey(_Path, "key1");
            if (data != null)
            {
                _objSecurity.detele_RegistryKey(_Path, "key1");
            }

            _objSecurity.set_RegistryKey(_Path, "key1", keyObj.Key);
            //object dataCheck = _objSecurity.get_RegistryKey(_Path, "key1");
            
            return "True";
        }
    }
    public class KeyActive
    {
        public string ID { get; set; }
        public string Key { get; set; }
    }
}
