using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_TabagheBandi
    {
        public int fldID { get; set; }
        public string fldName { get; set; }
        public int fldComisionID { get; set; }
        public Nullable<int> fldPID { get; set; }
        public int fldOrganID { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
        public string chidId { get; set; }
        public string childName { get; set; }
    }
}