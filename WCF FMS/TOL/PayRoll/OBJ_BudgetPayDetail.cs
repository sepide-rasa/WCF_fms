using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_BudgetPayDetail
    {
        public int fldId { get; set; }
        public int fldHeaderId { get; set; }
        public int fldTypeEstekhdamId { get; set; }
        public int fldTypeBimeId { get; set; }
        public string fldTitleEstekhdam { get; set; }
        public string fldTitleBime { get; set; }
    }
}