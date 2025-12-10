using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Mohasebat_kosorat_MotalebatParam
    {
        public int fldId { get; set; }
        public int fldMohasebatId { get; set; }
        public Nullable<int> fldKosoratId { get; set; }
        public Nullable<int> fldMotalebatId { get; set; }
        public int fldMablagh { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
    }
}