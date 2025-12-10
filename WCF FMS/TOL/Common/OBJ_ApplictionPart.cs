using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_ApplictionPart
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public Nullable<int> fldPID { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public Nullable<int> fldModuleId { get; set; }
    }
}