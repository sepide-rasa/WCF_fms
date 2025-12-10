using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_KosouratDetails
    {
        public string fldTitle { get; set; }
        public int fldMablagh { get; set; }
        public int fldPersonalId { get; set; }
        public int fldMashmolBime { get; set; }
        public int fldMashmolMaliyat { get; set; }
        public short fldYearPardakht { get; set; }
        public byte fldMonthPardakht { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public byte fldKarkard { get; set; }
        public Nullable<int> fldHokmId { get; set; }
        public int fldtype { get; set; }
    }
}