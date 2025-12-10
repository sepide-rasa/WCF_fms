using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_UserGroup_ModuleOrgan
    {
        public int fldId { get; set; }
        public int fldUserGroupId { get; set; }
        public int fldModuleOrganId { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldModuleOrganName { get; set; }
    }
}