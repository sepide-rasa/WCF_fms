using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Employee
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldCodemeli { get; set; }
        public long fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public bool fldStatus { get; set; }
        public string fldStatusName { get; set; }
        public string fldFatherName { get; set; }
        public byte fldTypeShakhs { get; set; }
        public string fldTypeShakhsName { get; set; }
        public string fldSh_Shenasname { get; set; }
        public string fldCodeMoshakhase { get; set; }
        public string fldMeli_Moshakhase { get; set; }
        public string fldPostEjraee { get; set; }
        public Nullable<int> fldOrganPostEjraeeId { get; set; }
    }
}