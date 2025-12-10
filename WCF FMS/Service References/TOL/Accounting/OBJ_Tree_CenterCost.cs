using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_Tree_CenterCost
    {
        public int fldId { get; set; }
        public int fldCenterCoId { get; set; }
        public int fldCostTreeId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
    }
}