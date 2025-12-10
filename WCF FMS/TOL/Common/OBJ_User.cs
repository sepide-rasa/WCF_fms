using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_User
    {
        public int fldId { get; set; }
        public int fldEmployeeId { get; set; }
        public string fldUserName { get; set; }
        public string fldPassword { get; set; }
        public bool fldActive_Deactive { get; set; }
        public string fldActive_DeactiveName { get; set; }
        public string fldNameEmployee { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldCodemeli { get; set; }
    }
}