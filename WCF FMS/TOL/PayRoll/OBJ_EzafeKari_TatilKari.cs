using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_EzafeKari_TatilKari
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public byte fldNobatePardakht { get; set; }
        public decimal fldCount { get; set; }
        public byte fldType { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldName_Father { get; set; }
        public string fldCodemeli { get; set; }
        public string fldSh_Personali { get; set; }
        public string fldNobatePardakhtName { get; set; }
        public string fldMonthName { get; set; }
        public bool fldHasBime { get; set; }
        public bool fldHasMaliyat { get; set; }
        public string fldHasBimeName { get; set; }
        public string fldHasMaliyatName { get; set; }
        public Nullable<int> fldOrganId { get; set; }

        public int fldPersonalInfoId { get; set; }
        public int fldPrs_PersonalInfoId { get; set; }
        public int fldEzafeKari_TatilKariId { get; set; }
        public Nullable<bool> fldChecked { get; set; }
        public Nullable<int> fldTypeEstekhdamId { get; set; }
        public Nullable<bool> fldFlag { get; set; }
    }
}