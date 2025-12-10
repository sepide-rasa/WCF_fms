using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_TemplateName
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public int fldAccountingTypeId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIp { get; set; }
        public int fldUserId { get; set; }
        public string fldName_AccountingType { get; set; }
    }
}