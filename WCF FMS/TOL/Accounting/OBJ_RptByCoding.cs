using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_RptByCoding
    {
        public Nullable<long> fldBedehkar { get; set; }
        public Nullable<long> fldBestankar { get; set; }
        public Nullable<long> MandehHeasb { get; set; }
        public Nullable<long> GardeshHesab { get; set; }
        public string fldTitle { get; set; }
        public int fldType { get; set; }
    }
}