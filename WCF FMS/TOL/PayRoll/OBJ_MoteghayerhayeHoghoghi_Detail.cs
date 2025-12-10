using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MoteghayerhayeHoghoghi_Detail
    {
        public int fldId { get; set; }
        public int fldMoteghayerhayeHoghoghiId { get; set; }
        public int fldItemEstekhdamId { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTitle { get; set; }
        public string fldTarikhEjra { get; set; }
        public string fldTarikhSodur { get; set; }
        public int fldZaribEzafeKar { get; set; }
        public decimal fldSaatKari { get; set; }
        public decimal fldDarsadBimePersonal { get; set; }
        public decimal fldDarsadbimeKarfarma { get; set; }
        public decimal fldDarsadBimeBikari { get; set; }
        public decimal fldDarsadBimeJanbazan { get; set; }
        public decimal fldHaghDarmanKarmand { get; set; }
        public decimal fldHaghDarmanKarfarma { get; set; }
        public decimal fldHaghDarmanDolat { get; set; }
        public int fldHaghDarmanMazad { get; set; }
        public int fldHaghDarmanTahteTakaffol { get; set; }
        public Nullable<bool> fldMazayaMashmool { get; set; }
    }
}