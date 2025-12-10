using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Setting
    {
        public int fldID { get; set; }
        public string fldEmailAddress { get; set; }
        public string fldEmailPassword { get; set; }
        public string fldRecieveServer { get; set; }
        public string fldSendServer { get; set; }
        public int fldSendPort { get; set; }
        public bool fldSSL { get; set; }
        public bool fldDelFax { get; set; }
        public bool fldIsSigner { get; set; }
        public string fldFaxPath { get; set; }
        public int fldOrganID { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
        public int fldRecievePort { get; set; }
        public string NameOrgan { get; set; }
    }
}