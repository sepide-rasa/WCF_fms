using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_RptListPardakhtEydi
    {
        public string fldName_Family { get; set; }
        public string fldFatherName { get; set; }
        public string fldShomareHesab { get; set; }
        public int fldKosurat { get; set; }
        public int fldMablagh { get; set; }
        public int fldMaliyat { get; set; }
        public int fldDayCount { get; set; }
        public int fldKhalesPardakhti { get; set; }
        public int fldPersonalId { get; set; }
        public string NameNobat { get; set; }
        public Nullable<short> Sal { get; set; }
    }
}