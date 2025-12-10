using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_CodehayeDaramad_Tas_him
    {
        public int fldCodingAcc_DetailsId { get; set; }
        public string fldTitle { get; set; }
        public string fldCode { get; set; }
        public string fldDaramadCode { get; set; }
        public Nullable<decimal> fldPercentHazine { get; set; }
        public Nullable<decimal> fldPercentTamallok { get; set; }
        public string fldHazine { get; set; }
        public string fldSarmaye { get; set; }
        public string fldMali { get; set; }
        public string fldHozeMasraf { get; set; }
        public string fldHozeMamooriyat { get; set; }
    }
}