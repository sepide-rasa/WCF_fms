using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ItemMablgh_Header
    {
        public int fldId { get; set; }
        public int fldActiveDate { get; set; }
        public Nullable<int> fldDeactiveDate { get; set; }
        public bool fldActive { get; set; }
        public string fldIp { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldActiveName { get; set; }
    }
}