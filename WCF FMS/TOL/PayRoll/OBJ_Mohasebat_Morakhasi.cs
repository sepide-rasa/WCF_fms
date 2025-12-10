using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Mohasebat_Morakhasi
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public byte fldTedad { get; set; }
        public int fldMablagh { get; set; }
        public byte fldMonth { get; set; }
        public short fldYear { get; set; }
        public byte fldNobatPardakht { get; set; }
        public short fldSalHokm { get; set; }
        public int fldHokmId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public Nullable<byte> fldHesabTypeId { get; set; }
    }
}