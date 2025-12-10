using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MohasebatEzafeKari_TatilKari
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public decimal fldTedad { get; set; }
        public int fldMablagh { get; set; }
        public int fldBimePersonal { get; set; }
        public int fldBimeKarFarma { get; set; }
        public int fldBimeBikari { get; set; }
        public int fldBimeSakht { get; set; }
        public decimal fldDarsadBimePersonal { get; set; }
        public decimal fldDarsadBimeKarFarma { get; set; }
        public decimal fldDarsadBimeBikari { get; set; }
        public decimal fldDarsadBimeSakht { get; set; }
        public int fldMashmolBime { get; set; }
        public int fldMashmolMaliyat { get; set; }
        public int fldNobatPardakht { get; set; }
        public byte fldType { get; set; }
        public int fldKhalesPardakhti { get; set; }
        public int fldMaliyat { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTypeName { get; set; }
        public Nullable<byte> fldHesabTypeId { get; set; }
    }
}