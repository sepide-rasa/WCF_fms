using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_User_Group
    {
        public int fldId { get; set; }
        public int fldUserGroupId { get; set; }
        public int fldUserSelectId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public bool fldGrant { get; set; }
        public bool fldWithGrant { get; set; }
        public string fldName { get; set; }
        public string fldCodemeli { get; set; }
        public string fldFatherName { get; set; }



    }
}