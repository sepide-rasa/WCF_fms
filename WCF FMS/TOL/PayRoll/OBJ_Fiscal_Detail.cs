using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Fiscal_Detail
    {
        public int fldId { get; set; }
        public int fldFiscalHeaderId { get; set; }
        public int fldAmountFrom { get; set; }
        public int fldAmountTo { get; set; }
        public decimal fldPercentTaxOnWorkers { get; set; }
        public decimal fldTaxationOfEmployees { get; set; }
        public int fldTax { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldEffectiveDate { get; set; }
        public string fldDateOfIssue { get; set; }
    }
}