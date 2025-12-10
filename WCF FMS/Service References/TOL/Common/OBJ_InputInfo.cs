using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_InputInfo
    {
        public int fldId { get; set; }
        public string fldDateTime { get; set; }
        public string fldTime { get; set; }
        public string fldIP { get; set; }
        public string fldMACAddress { get; set; }
        public bool fldLoginType { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string Name_Family { get; set; }
        public string fldLoginTypeName { get; set; }
    }
}