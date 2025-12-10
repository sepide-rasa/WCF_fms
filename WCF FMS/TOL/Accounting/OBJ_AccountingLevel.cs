using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_AccountingLevel
    {
        public int fldId { get; set; } 
        public int fldOrganId { get; set; }
        public short fldYear { get; set; }
        public int fldArghamNum { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public string fldName { get; set; }
        public Nullable<long> fldLevelId { get; set; }
    }
}