using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_DisketBime
    {
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldFatherName { get; set; }
        public long? fldBimePersonal { get; set; }
        public long? fldBimeKarFarma { get; set; }
        public long? fldMashmolBime { get; set; }
        public long? fldBimeBikari { get; set; }
        public string fldJobeCode { get; set; }
        public string fldJobDesc { get; set; }
        public int fldKarkard { get; set; }
        public string fldCodemeli { get; set; }
        public string fldShomareBime { get; set; }
        public string fldSh_Shenasname { get; set; }
        public string fldTarikhEstekhdam { get; set; }
        public long? fldItem { get; set; }
        public long? KargariMahane { get; set; }
        public long KarmandiMahane { get; set; }
        public int? fldNoeEstekhdamId { get; set; }
        public string fldTarikhTavalod { get; set; }
        public bool fldMeliyat { get; set; }
        public bool fldJensiyat { get; set; }
        public int fldPayeSanavati { get; set; }
        public int fldTaahol { get; set; }
        public string NameSodoor { get; set; }
        public string fldSh_Personali { get; set; }
        public decimal fldDarsadBimeKarFarma { get; set; }
        public decimal fldDarsadBimePersonal { get; set; }
    }
}