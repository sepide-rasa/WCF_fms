using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_SayerPardakhtGroup
    {
        public int fldPersonalInfoId { get; set; }
        public string fldName { get; set; }
        public string fldCodemeli { get; set; }
        public string fldSh_Personali { get; set; }
        public int fldSayerPardakhtId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public int fldAmount { get; set; }
        public string fldTitle { get; set; }
        public byte fldNobatePardakt { get; set; }
        public byte fldMarhalePardakht { get; set; }
        public Nullable<bool> fldChecked { get; set; }
        public int fldCostCenterId { get; set; }
        public string Expr1 { get; set; }
        public string fldShomareHesab { get; set; }
        public bool fldMoafAsMaliyat { get; set; }
        public int fldKhalesPardakhti { get; set; }
        public int fldMaliyat { get; set; }
        public bool fldHasMaliyat { get; set; }
        public int fldShomareHesabsId { get; set; }
    }
}