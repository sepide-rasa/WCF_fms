using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_BankBillHeader
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public int fldShomareHesabId { get; set; }
        public int fldFiscalYearId { get; set; }
        public string fldJsonFile { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public int fldPatternId { get; set; }
        public string fldNamePattern { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldBankName { get; set; }
    }
}