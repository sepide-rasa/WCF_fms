using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_GHarardadBime
    {
        public int fldId { get; set; }
        public string fldNameBime { get; set; }
        public string fldTarikhSHoro { get; set; }
        public string fldTarikhPayan { get; set; }
        public int fldMablagheBimeSHodeAsli { get; set; }
        public int fldMablaghe60Sal { get; set; }
        public int fldMablaghe70Sal { get; set; }
        public int fldMablagheBimeOmr { get; set; }
        public byte fldMaxBimeAsli { get; set; }
        public int fldDarsadBimeOmr { get; set; }
        public int fldDarsadBimeTakmily { get; set; }
        public int fldDarsadBime60Sal { get; set; }
        public int fldDarsadBime70Sal { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldMaxBimeAsliName { get; set; }
        public int fldDarsadBimeBedonePoshesh { get; set; }
        public int fldMablagheBedonePoshesh { get; set; }
    }
}