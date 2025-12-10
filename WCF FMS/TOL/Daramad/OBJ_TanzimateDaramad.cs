using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_TanzimateDaramad
    {
        public int fldId { get; set; }
        public int fldAvarezId { get; set; }
        public int fldMaliyatId { get; set; }
        public int fldTakhirId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldMablaghGerdKardan { get; set; }
        public int fldOrganId { get; set; }
        public string fldTitle_CodeAvarez { get; set; }
        public string fldTitle_CodeMaliyat { get; set; }
        public string fldTitle_CodeTakhir { get; set; }
        public decimal fldNerkh { get; set; }
        public bool fldChapShenaseGhabz_Pardakht { get; set; }
        public byte fldShorooshenaseGhabz { get; set; }
        public string fldBankName { get; set; }
        public string fldNameShobe { get; set; }
        public int fldCodeSHobe { get; set; }
        public string fldOrganName { get; set; }
        public string fldAddressOrgan { get; set; }
        public int fldShomareHesabIdPishfarz { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldFormul { get; set; }
        public bool fldSumMaliyat_Avarez { get; set; }
    }
}