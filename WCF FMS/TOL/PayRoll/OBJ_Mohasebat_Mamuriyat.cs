using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Mohasebat_Mamuriyat
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public byte fldTedadBaBeytute { get; set; }
        public byte fldTedadBedunBeytute { get; set; }
        public int fldMablagh { get; set; }
        public int fldBimePersonal { get; set; }
        public int fldBimeKarFarma { get; set; }
        public int fldBimeBikari { get; set; }
        public int fldBimeSakht { get; set; }
        public decimal fldDarsadBimePersonal { get; set; }
        public decimal fldDarsadBimeKarFarma { get; set; }
        public decimal fldDarsadBimeBiKari { get; set; }
        public decimal fldDarsadBimeSakht { get; set; }
        public int fldMashmolBime { get; set; }
        public int fldMashmolMaliyat { get; set; }
        public int fldKhalesPardakhti { get; set; }
        public int fldMaliyat { get; set; }
        public int fldTashilat { get; set; }
        public byte fldNobatePardakht { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public Nullable<byte> fldHesabTypeId { get; set; }
    }
}