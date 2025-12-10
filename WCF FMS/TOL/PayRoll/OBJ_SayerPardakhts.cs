using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_SayerPardakhts
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public int fldAmount { get; set; }
        public string fldTitle { get; set; }
        public byte fldNobatePardakt { get; set; }
        public byte fldMarhalePardakht { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldSh_Personali { get; set; }
        public int fldEmployeeId { get; set; }
        public string fldName_Father { get; set; }
        public string fldCodemeli { get; set; }
        public string fldNobatePardaktName { get; set; }
        public string fldMarhalePardakhtName { get; set; }
        public string fldMonthName { get; set; }
        public bool fldHasMaliyat { get; set; }
        public int fldMaliyat { get; set; }
        public int fldKhalesPardakhti { get; set; }
        public string fldJobeCode { get; set; }
        public Nullable<bool> fldFlag { get; set; }
        public Nullable<byte> fldMostamar { get; set; }
        public string fldNameNoeMostamar { get; set; }
    }
}