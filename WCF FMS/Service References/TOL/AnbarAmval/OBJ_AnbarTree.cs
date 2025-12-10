using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.AnbarAmval
{
    public class OBJ_AnbarTree
    {
        public int fldId { get; set; }
        public Nullable<int> fldPID { get; set; }
        public string fldName { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public int fldNodeType { get; set; }
        public int fldGroupId { get; set; }
        public int fldAnbar_treeId { get; set; }
    }
}