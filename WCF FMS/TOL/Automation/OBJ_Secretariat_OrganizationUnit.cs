using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WCF_FMS.TOL.Automation
 {
    public class OBJ_Secretariat_OrganizationUnit
    {
        public Int32 fldID { get; set; }
        public Int32 fldSecretariatID { get; set; }
        public Int32 fldOrganizationUnitID { get; set; }
        public DateTime fldDate { get; set; }
        public Int32 fldUserID { get; set; }
        public String fldDesc { get; set; }
        public String fldIP { get; set; }
        public Int32 fldOrganId { get; set; }
        public string fldTitle { get; set; }
    }
}