using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_CodingBudje
    {
        public int fldId { get; set; }
        public Nullable<short> fldLevelId { get; set; }
        public string fldStrhid { get; set; }
        public int fldTemplateCodingId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
    }
}