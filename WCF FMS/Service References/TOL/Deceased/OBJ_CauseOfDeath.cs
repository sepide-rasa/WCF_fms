using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_CauseOfDeath
    {
        public int fldId { get; set; }
        public string fldReason { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
    }
}