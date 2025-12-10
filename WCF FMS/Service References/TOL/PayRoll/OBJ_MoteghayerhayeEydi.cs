using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MoteghayerhayeEydi
    {
        public int fldId { get; set; }
        public short fldYear { get; set; }
        public int fldMaxEydiKarmand { get; set; }
        public int fldMaxEydiKargar { get; set; }
        public decimal fldZaribEydiKargari { get; set; }
        public bool fldTypeMohasebatMaliyat { get; set; }
        public int fldMablaghMoafiatKarmand { get; set; }
        public int fldMablaghMoafiatKargar { get; set; }
        public decimal fldDarsadMaliyatKarmand { get; set; }
        public decimal fldDarsadMaliyatKargar { get; set; }
        public bool fldTypeMohasebe { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTypeMohasebatMaliyatName { get; set; }
        public string fldTypeMohasebeName { get; set; }
    }
}