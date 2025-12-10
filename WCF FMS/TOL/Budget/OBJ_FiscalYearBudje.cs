using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_FiscalYearBudje
    {
        public int fldId { get; set; }
        public short fldYear { get; set; }
        public string fldDesc { get; set; }
        public int fldOrganId { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
    }
}