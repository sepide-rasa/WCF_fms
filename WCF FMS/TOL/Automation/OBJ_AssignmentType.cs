using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_AssignmentType
    {
        public int fldID { get; set; }
        public string fldType { get; set; }
        public int fldOrganID { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
    }
}