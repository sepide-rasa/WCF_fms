using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Permission
    {
        public int fldId { get; set; }
        public int fldUserGroup_ModuleOrganID { get; set; }
        public int fldApplicationPartId { get; set; }
        public int UserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}