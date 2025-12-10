using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MoteghayerhayeHoghoghi
    {
        public int fldId { get; set; }
        public string fldTarikhEjra { get; set; }
        public string fldTarikhSodur { get; set; }
        public int fldZaribEzafeKar { get; set; }
        public decimal fldSaatKari { get; set; }
        public decimal fldDarsadBimePersonal { get; set; }
        public decimal fldDarsadbimeKarfarma { get; set; }
        public decimal fldDarsadBimeBikari { get; set; }
        public decimal fldDarsadBimeJanbazan { get; set; }
        public decimal fldHaghDarmanKarmand { get; set; }
        public decimal fldHaghDarmanKarFarma { get; set; }
        public decimal fldHaghDarmanDolat { get; set; }
        public int fldHaghDarmanMazad { get; set; }
        public int fldHaghDarmanTahteTakaffol { get; set; }
        public decimal fldDarsadBimeMashagheleZiyanAvar { get; set; }
        public int fldMaxHaghDarman { get; set; }
        public int fldZaribHoghoghiSal { get; set; }
        public bool fldHoghogh { get; set; }
        public bool fldFoghShoghl { get; set; }
        public bool fldTafavotTatbigh { get; set; }
        public bool fldFoghVizhe { get; set; }
        public bool fldHaghJazb { get; set; }
        public bool fldTadil { get; set; }
        public bool fldBarJastegi { get; set; }
        public bool fldSanavat { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTypeBimeName { get; set; }
        public int fldTypeBimeId { get; set; }
        public int fldAnvaeEstekhdamId { get; set; }
        public string fldAnvaeEstekhdamTitle { get; set; }
        public bool fldFoghTalash { get; set; }
    }
}