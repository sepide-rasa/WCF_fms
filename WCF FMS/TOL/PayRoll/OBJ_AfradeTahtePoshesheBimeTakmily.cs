using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_AfradeTahtePoshesheBimeTakmily
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public int fldTedadAsli { get; set; }
        public int fldTedadTakafol60Sal { get; set; }
        public int fldTedadTakafol70Sal { get; set; }
        public int fldGHarardadBimeId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldSh_Personali { get; set; }
        public string fldName_Father { get; set; }
        public string fldCodemeli { get; set; }
        public string fldNameBime { get; set; }
        public string fldAfradTahtePoshehsId { get; set; }
        public byte fldTedadBedonePoshesh { get; set; }
    }
}