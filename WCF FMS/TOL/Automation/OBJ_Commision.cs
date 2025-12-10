using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Commision
    {
        public int fldID { get; set; }
        public int fldAshkhasID { get; set; }
        public int fldOrganizPostEjraeeID { get; set; }
        public string fldStartDate { get; set; }
        public string fldEndDate { get; set; }
        public string fldOrganicNumber { get; set; }
        public int fldOrganID { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
        public string fldO_postEjraee_Title { get; set; }
        public string fldCodeMelli { get; set; }
        public string fldName { get; set; }
        public string fldTypeShakhs { get; set; }
        public string fldActive { get; set; }
        public string fldFatherName { get; set; }
        public bool fldSign { get; set; }
        public string fldSignName { get; set; }
    }
}