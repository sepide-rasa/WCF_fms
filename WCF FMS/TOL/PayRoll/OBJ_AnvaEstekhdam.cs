using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_AnvaEstekhdam
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public string fldTitleNoeEstekhdam { get; set; }
        public int fldNoeEstekhdamId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public Nullable<int> fldPatternNoeEstekhdamId { get; set; }
        public string fldTitlePattern { get; set; }
        public Nullable<byte> fldTypeEstekhdamFormul { get; set; }
    }
}