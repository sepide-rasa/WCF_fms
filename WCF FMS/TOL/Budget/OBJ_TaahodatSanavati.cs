 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_TaahodatSanavati
    {
        public int fldId { get; set; }
        public Nullable<long> fldD1 { get; set; }
        public Nullable<long> fldD2 { get; set; }
        public Nullable<long> fldD3 { get; set; }
        public Nullable<long> fldH1 { get; set; }
        public Nullable<long> fldH2 { get; set; }
        public Nullable<long> fldH3 { get; set; }
        public Nullable<long> fldH4 { get; set; }
        public int fldFiscalYearId { get; set; }
        public int fldUserId { get; set; }
        public string fldIp { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}