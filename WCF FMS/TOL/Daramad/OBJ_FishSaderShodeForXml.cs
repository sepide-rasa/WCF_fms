using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_FishSaderShodeForXml
    {
        public long MablaghPardakhtShode { get; set; }
        public Nullable<long> Avarez { get; set; }
        public Nullable<long> Maliyat { get; set; }
        public string TarikhSodoor { get; set; }
        public string TarikhPardakht { get; set; }
        public int NoePardakht { get; set; }
        public string CodeRahgiri { get; set; }
        public string CodeErja { get; set; }
        public string TarikhVarizBeHesab { get; set; }
        public string ShomareHesabVariz { get; set; }
        public string Infi_Bank { get; set; }
        public string OrganName { get; set; }
        public string ShenaseMeliOrgan { get; set; }
        public string NameBank { get; set; }
        public string NoeMoadi { get; set; }
        public string NameMoadi { get; set; }
        public string FamilyMoadi { get; set; }
        public string CodeMeli { get; set; }
        public string NoeSherkat { get; set; }
        public string ShenaseMeliSherkat { get; set; }
        public string ShomareSabt { get; set; }
        public string CodeDaramadElamAvarez { get; set; }
        public int SerialFish { get; set; }
        public int ElamAvarezId { get; set; }
        public bool fldSendToMaliFlag { get; set; }
        public bool fldFishSentFlag { get; set; }
        public Nullable<System.DateTime> fldDateSendToMali { get; set; }
        public Nullable<System.DateTime> fldDateFishSent { get; set; }
        public Nullable<long> AmuzeshParvaresh { get; set; }
    }
}