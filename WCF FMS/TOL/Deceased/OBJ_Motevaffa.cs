using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_Motevaffa
    {
        public int fldId { get; set; }
        public Nullable<int> fldCauseOfDeathId { get; set; }
        public int fldGhabreAmanatId { get; set; }
        public string fldTarikhFot { get; set; }
        public string fldTarikhDafn { get; set; }
        public int fldOrganId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public Nullable<int> fldMahalFotId { get; set; }
        public string fldNameMahal { get; set; }
        public string fldReason { get; set; }
        public string fldname { get; set; }
        public string fldFamily { get; set; }
        public string fldShomare { get; set; }
        public string fldFatherName { get; set; }
        public string fldCodemeli { get; set; }
        public string fldSh_Shenasname { get; set; }
        public string fldCodeMoshakhase { get; set; }
        public Nullable<int> fldGheteId { get; set; }
        public Nullable<int> fldRadifId { get; set; }
        public Nullable<int> fldVadiSalamId { get; set; }
        public string fldNameVadiSalam { get; set; }
        public string fldNameGhete { get; set; }
        public string fldNameRadif { get; set; }
        public string fldTypeNameMotevafa { get; set; }
        public int fldTypeMotevafa { get; set; }
        public int fldShomareId { get; set; }
        public string fldCodeMotevafa { get; set; }
        public byte fldShomareTabaghe { get; set; }
    }
}