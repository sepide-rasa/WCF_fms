using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_BudjeLevel
    {
        public Nullable<int> fldId { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public Nullable<short> fldYear { get; set; }
        public Nullable<int> fldArghamNum { get; set; }
        public string fldName { get; set; }
    }
}