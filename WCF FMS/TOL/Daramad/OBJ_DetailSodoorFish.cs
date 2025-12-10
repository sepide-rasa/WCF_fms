using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_DetailSodoorFish
    {
        public string fldSharheCodeDaramad { get; set; }
        public long fldAsliValue { get; set; }
        public long fldAvarezValue { get; set; }
        public long fldMaliyatValue { get; set; }
        public int fldCodeDaramadId { get; set; }
        public int fldShomareHesabId { get; set; }
        public string fldShomareHesab { get; set; }
        public byte fldShorooshenaseGhabz { get; set; }
        public Nullable<long> fldAmuzeshParvareshValue { get; set; }
    }
}