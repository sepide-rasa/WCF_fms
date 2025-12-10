using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Vam
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public string fldTarikhDaryaft { get; set; }
        public byte fldTypeVam { get; set; }
        public string fldTypeVamName { get; set; }
        public int fldMablaghVam { get; set; }
        public string fldStartDate { get; set; }
        public short fldCount { get; set; }
        public int fldMablagh { get; set; }
        public int fldMandeVam { get; set; }
        public bool fldStatus { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldName_Father { get; set; }
        public string fldCodemeli { get; set; }
        public string fldSh_Personali { get; set; }
        public string fldStatusName { get; set; }
    }
}