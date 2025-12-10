using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_SelectVariziForBank
    {
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldFatherName { get; set; }
        public long fldkhalesPardakhti { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldCodemeli { get; set; }
        public string fldAddress { get; set; }
        public int fldEsargariId { get; set; }
        public string fldTarikhEstekhdam { get; set; }
        public string fldCodePosti { get; set; }
        public string fldShomareBime { get; set; }
        public int fldMadrakId { get; set; }
        public string fldRasteShoghli { get; set; }
        public int fldTypeBimeId { get; set; }
        public bool fldMeliyat { get; set; }
        public string MahalKhedmat { get; set; }
        public string Semat { get; set; }
        public int fldMaliyat { get; set; }
        public int  fldNoeEstekhdam { get; set; }
        public int fldPersonalId { get; set; }
        public int fldPayPersonalId { get; set; }
        public int fldMablagh { get; set; }
        public Nullable<byte> fldMaliyatEsargari { get; set; }
    }
}