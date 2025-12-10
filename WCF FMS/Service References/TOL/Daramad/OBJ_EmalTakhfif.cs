using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_EmalTakhfif
    {
        public int fldID { get; set; }
        public int fldTedad { get; set; }
        public Nullable<long> AsliValue { get; set; }
        public Nullable<long> fldTakhfifAsliValue { get; set; }
        public string fldSharheCodeDaramad { get; set; }
        public string fldDaramadCode { get; set; }
    }
}