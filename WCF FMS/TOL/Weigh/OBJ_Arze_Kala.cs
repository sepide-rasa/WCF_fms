using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_Arze_Kala
    {
        public Nullable<int> fldId { get; set; }
        public int fldKalaId { get; set; }
        public int fldCodeDaramadId { get; set; }
        public int fldParametrSabetDaramadId { get; set; }
        public string fldSharheCodeDaramad { get; set; }
        public string fldNameParametreFa { get; set; }
        public string fldKalaName { get; set; }
        public string fldNameWeighbridge { get; set; }
        public int fldShomareHesabCodeDaramadId { get; set; }
    }
}