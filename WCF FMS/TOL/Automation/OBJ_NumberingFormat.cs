using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_NumberingFormat
    {
        public int fldID { get; set; }
        public int fldYear { get; set; }
        public int fldSecretariatID { get; set; }
        public string fldNumberFormat { get; set; }
        public int fldStartNumber { get; set; }
        public int fldOrganID { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
    }
}