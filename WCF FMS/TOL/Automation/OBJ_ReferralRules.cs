using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_ReferralRules
    {
        public int fldId { get; set; }
        public int fldPostErjaDahandeId { get; set; }
        public int? fldPostErjaGirandeId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTitleErjaDahande { get; set; }
        public string fldTitleErjaGirande { get; set; }
        public Nullable<int> fldChartEjraeeGirandeId { get; set; }
    }
}