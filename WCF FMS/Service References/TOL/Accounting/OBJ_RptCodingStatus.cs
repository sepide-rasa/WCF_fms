using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_RptCodingStatus
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public string fldParentTitle { get; set; }
        public Nullable<long> fldMande { get; set; }
        public string fldTypeName { get; set; }
        public int fldType { get; set; }
        public string fldParvande { get; set; }
        public int fldCaseTypeId { get; set; }
        public int fldSourceId { get; set; }
        public Nullable<int> fldMahiyatId { get; set; }
        public int fldNoe_Mahiyat { get; set; }
        public int fldNoe_Mande { get; set; }
    }
}