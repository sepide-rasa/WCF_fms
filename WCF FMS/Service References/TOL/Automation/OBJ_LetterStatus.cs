using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_LetterStatus
    {
        public int fldID { get; set; }
        public string fldName { get; set; }
        public string fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public Nullable<System.TimeSpan> fldDateTime { get; set; }
        public string fldUserName { get; set; }
    }
}