using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_BankTemplate_Header
    {
        public int fldId { get; set; }
        public string fldNamePattern { get; set; }
        public short fldStartRow { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public string fldBankName { get; set; }
        public string fldPasvand { get; set; }
        public Nullable<int> fldFileId { get; set; }
        public string fldBankId { get; set; }
        public string fldDetailsId { get; set; }
    }
}