using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_Motammam
    {
        public int fldId { get; set; }
        public int fldFiscalYearId { get; set; }
        public string fldTarikh { get; set; }
        public string fldDesc { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public System.DateTime fldDate { get; set; }
        public short fldYear { get; set; }
    }
}