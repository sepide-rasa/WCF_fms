using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_CodeDaramadAramestan
    {
        public int fldId { get; set; }
        public int fldCodeDaramadId { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldorganid { get; set; }
        public string fldDaramadTitle { get; set; }
        public string fldShomareHesab { get; set; }
        public bool fldMashmooleArzesheAfzoode { get; set; }
        public bool fldMashmooleKarmozd { get; set; }
        public string fldNameVahed { get; set; }
        public string fldDaramadCode { get; set; }
    }
}