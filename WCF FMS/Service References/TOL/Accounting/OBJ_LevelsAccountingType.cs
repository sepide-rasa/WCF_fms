using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_LevelsAccountingType
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public int fldAccountTypeId { get; set; }
        public int fldArghumNum { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime flddate { get; set; }
        public string fldIp { get; set; }
        public int fldUserId { get; set; }
        public string fldName_AccountingType { get; set; }
    }
}