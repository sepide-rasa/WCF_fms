using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_SumKalaHavale_Detail
    {
        public int fldId { get; set; }
        public Nullable<decimal> fldVaznKol { get; set; }
        public Nullable<decimal> fldVaznKhals { get; set; }
        public Nullable<int> fldRemittanceId { get; set; }
        public string fldTarikhVaznKhali { get; set; }
        public string fldNameRanande { get; set; }
        public string fldNameKala { get; set; }
        public string fldNamePlace { get; set; }
        public string fldPlaque { get; set; }
        public string fldTarikh_TimeTozin { get; set; }
        public string fldIsporName { get; set; }
        public Nullable<decimal> fldVaznKhali { get; set; }
        public string fldNameKhodro { get; set; }
        public string fldNameHavale { get; set; }
        public string fldNameBaskool { get; set; }
    }
}