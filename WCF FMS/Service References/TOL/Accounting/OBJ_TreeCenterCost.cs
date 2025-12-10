using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_TreeCenterCost
    {
        public int fldId { get; set; }
        public int fldOrganId { get; set; }
        public int fldGroupCenterCoId { get; set; }
        public Nullable<int> fldPID { get; set; }
        public string fldName { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public int fldNodeType { get; set; }
        public int fldCenter_treeId { get; set; }
    }
}