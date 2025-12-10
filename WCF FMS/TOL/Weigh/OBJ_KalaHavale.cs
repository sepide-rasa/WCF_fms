using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_KalaHavale
    {
        public string fldNameKala { get; set; }
        public int fldMaxTon { get; set; }
        public Nullable<double> fldSumKala { get; set; }
        public Nullable<double> fldBaghimande { get; set; }
        public int fldKalaid { get; set; }
        public string fldNameHeader { get; set; }
    }
}