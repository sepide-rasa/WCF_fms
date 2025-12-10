using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_DaramadGroup_Parametr
    {
        public int fldId { get; set; }
        public int fldDaramadGroupId { get; set; }
        public string fldEnName { get; set; }
        public string fldFnName { get; set; }
        public bool fldStatus { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldStatusName { get; set; }
        public byte fldNoeField { get; set; }
        public Nullable<int> fldComboBoxId { get; set; }
        public Nullable<int> fldFormuleId { get; set; }
        public string NoeFieldName { get; set; }
    }
}