using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_Anticipation
    {
        public int fldId { get; set; }
        public int? fldCodingAcc_DetailsId { get; set; }
        public int? fldCodingBudje_DetailsId { get; set; }
        public long fldMablagh { get; set; }
        public int fldBudgetTypeId { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserId { get; set; }
        public int? fldMotammamId { get; set; }
        public string fldTitleAcc { get; set; }
    }
}