using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_VaziyatEsargari
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public bool fldMoafAsBime { get; set; }
        public bool fldMoafAsMaliyat { get; set; }
        public bool fldMoafAsBimeOmr { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldMoafAsBimeName { get; set; }
        public string fldMoafAsMaliyatName { get; set; }
        public string fldMoafAsBimeOmrName { get; set; }
        public bool fldMoafAsBimeTakmili { get; set; }
        public string fldMoafAsBimeTakmiliName { get; set; }
    }
}