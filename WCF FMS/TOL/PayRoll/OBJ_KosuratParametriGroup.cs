using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_KosuratParametriGroup
    {
        public int fldPersonalInfoId { get; set; }
        public string fldName { get; set; }
        public string fldName_Father { get; set; }
        public string fldCodemeli { get; set; }
        public string fldSh_Personali { get; set; }
        public string fldTitle { get; set; }
        public int fldId { get; set; }
        public int fldNoeEstekhdamId { get; set; }
        public Nullable<bool> fldChecked { get; set; }
        public int fldMondeGHabl { get; set; }
    }
}