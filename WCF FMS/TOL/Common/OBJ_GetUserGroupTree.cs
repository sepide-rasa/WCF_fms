using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_GetUserGroupTree
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public Nullable<bool> fldGrant { get; set; }
        public Nullable<bool> fldWithGrant { get; set; }
        public int fldUserID { get; set; }
        public Nullable<bool> fldWithGrantLogin { get; set; }
    }
}