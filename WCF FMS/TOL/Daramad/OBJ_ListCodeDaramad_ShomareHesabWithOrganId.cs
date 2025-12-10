using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_ListCodeDaramad_ShomareHesabWithOrganId
    {
        public int fldId { get; set; }
        public string fldDaramadCode { get; set; }
        public string fldDaramadTitle { get; set; }
        public string fldNameVahed { get; set; }
        public string fldShomareHesab { get; set; }
        public int fldshomarehesabId { get; set; }
        public bool fldMashmooleArzesheAfzoode { get; set; }
        public bool fldMashmooleKarmozd { get; set; }
        public string fldDesc { get; set; }
        public int fldShomareHsabCodeDaramadId { get; set; }
        public byte fldShorooshenaseGhabz { get; set; }
        public bool fldStatus { get; set; }
    }
}