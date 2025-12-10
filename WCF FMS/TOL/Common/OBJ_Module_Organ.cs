using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Module_Organ
    {
        public int fldId { get; set; }
        public int fldModuleId { get; set; }
        public int fldOrganId { get; set; }
        public string fldNameOrgan { get; set; }
        public string fldNameModule { get; set; }
        public string fldNameModule_Organ { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldPermissionId { get; set; }
    }
}