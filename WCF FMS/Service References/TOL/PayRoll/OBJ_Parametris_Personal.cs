using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Parametris_Personal
    {
        public int fldId { get; set; }
        public Nullable<int> fldKosuratId { get; set; }
        public Nullable<int> fldMotalebatId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public int fldMablagh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}