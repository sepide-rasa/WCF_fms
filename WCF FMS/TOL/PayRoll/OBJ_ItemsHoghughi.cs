using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ItemsHoghughi
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public string fldNameEN { get; set; }
        public byte fldType { get; set; }
        public Nullable<byte> fldTypeHesabId { get; set; }
        public string fldTitleHesab { get; set; }
        public Nullable<byte> fldMostamar { get; set; }
        public string fldMostamarName { get; set; }
    }
}