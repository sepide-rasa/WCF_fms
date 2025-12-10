using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_Ashkhas_Taghsit
    {
        public int fldId { get; set; }
        public string fldTarikhSarResid { get; set; }
        public int fldReplyTaghsitId { get; set; }
        public string fldShomareSanad { get; set; }
        public long fldMablaghSanad { get; set; }
        public int fldShomareHesabId { get; set; }
        public int fldBaratDarId { get; set; }
        public Nullable<byte> fldTypeSanad { get; set; }
        public string fldMakanPardakht { get; set; }
        public string fldTypeSanadName { get; set; }
        public string fldDateStatus { get; set; }
        public string fldStatusName { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldBankName { get; set; }
        public int fldBankId { get; set; }
        public string fldNameShobe { get; set; }
        public int fldShobeId { get; set; }
        public string fldNameBaratDar { get; set; }
        public int fldShomareHesabIdOrgan { get; set; }
        public string fldShomareHesabOrgan { get; set; }
        public string fldTarikhSabt { get; set; }
        public string fldNameSaderKonandeCheck { get; set; }
    }
}