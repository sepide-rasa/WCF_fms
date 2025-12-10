using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MoteghayerhaAhkam
    {
        public int fldId { get; set; }
        public short fldYear { get; set; }
        public bool fldType { get; set; }
        public int fldHagheOlad { get; set; }
        public int fldHagheAeleMandi { get; set; }
        public int fldKharoBar { get; set; }
        public int fldMaskan { get; set; }
        public int fldKharoBarMojarad { get; set; }
        public int fldHadaghalDaryafti { get; set; }
        public int fldHaghBon { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTypeName { get; set; }
        public int fldHadaghalTadil { get; set; }
    }
}