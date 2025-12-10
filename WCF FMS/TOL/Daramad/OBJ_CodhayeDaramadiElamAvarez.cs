using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_CodhayeDaramadiElamAvarez
    {
        public int fldID { get; set; }
        public int fldElamAvarezId { get; set; }
        public string fldSharheCodeDaramad { get; set; }
        public long fldAsliValue { get; set; }
        public long fldAvarezValue { get; set; }
        public long fldMaliyatValue { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldShomareHesabId { get; set; }
        public string codeDaramadTitle { get; set; }
        public int fldTedad { get; set; }
        public int fldShomareHesabCodeDaramadId { get; set; }
        public string fldDaramadTitle { get; set; }
        public string fldDaramadCode { get; set; }
        public byte fldShorooshenaseGhabz { get; set; }
        public Nullable<long> fldSumMablgh { get; set; }
        public Nullable<long> fldTakhfifAsliValue { get; set; }
        public Nullable<long> fldTakhfifAvarezValue { get; set; }
        public Nullable<long> fldTakhfifMaliyatValue { get; set; }
        public long fldAmuzeshParvareshValue { get; set; }
        public Nullable<long> fldTakhfifAmuzeshParvareshValue { get; set; }
    }
}