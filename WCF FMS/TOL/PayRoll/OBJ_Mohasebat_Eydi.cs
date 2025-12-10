using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Mohasebat_Eydi
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public int fldMablagh { get; set; }
        public int fldMaliyat { get; set; }
        public int fldKosurat { get; set; }
        public int fldKhalesPardakhti { get; set; }
        public int fldNobatPardakht { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldDayCount { get; set; }
        public Nullable<byte> fldHesabTypeId { get; set; }
    }
}