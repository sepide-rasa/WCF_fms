using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ItemsMablgh
    {
        public int fldId { get; set; }
        public Nullable<int> fldHeaderId { get; set; }
        public int fldItemsHoghughiId { get; set; }
        public int fldMablagh { get; set; }
        public decimal fldPercentW_H { get; set; }
        public decimal fldPercentChild { get; set; }
        public byte fldCount { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldItemHoghughiTitle { get; set; }
    }
}