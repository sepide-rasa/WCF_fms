using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_SodoorFish
    {
        public int fldId { get; set; }
        public int fldElamAvarezId { get; set; }
        public int fldShomareHesabId { get; set; }
        public string fldShenaseGhabz { get; set; }
        public long fldMablaghAvarezGerdShode { get; set; }
        public byte fldShorooShenaseGhabz { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldShenasePardakht { get; set; }
        public string fldStatusName { get; set; }
        public string fldStatusId { get; set; }
        public int fldOrganId { get; set; }
        public string fldBarcode { get; set; }
        public bool fldSendToMaliFlag { get; set; }
        public bool fldFishSentFlag { get; set; }
        public Nullable<System.DateTime> fldDateSendToMali { get; set; }
        public Nullable<System.DateTime> fldDateFishSent { get; set; }




        public int fldItem { get; set; }
        public long fldMaliyat { get; set; }
        public long fldAvarez { get; set; }
        public long fldJamKol { get; set; }
        public long fldJamFish { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldStatus { get; set; }
        public long fldAsliValue { get; set; }
        public long fldMablaghTakhfif { get; set; }
        public string PardakhtStatus { get; set; }
        public Nullable<long> fldAmuzeshParvareshValue { get; set; }
    }
}