using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_RptKosouratBank
    {
        public int fldId { get; set; }
        public string fldNameBank { get; set; }
        public Nullable<int> fldMablagh { get; set; }
        public int fldShobeId { get; set; }
        public short fldYear { get; set; }
        public string fldMonth { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public int fldBankId { get; set; }
        public string fldDesc { get; set; }
        public string fldFatherName { get; set; }
    }
}