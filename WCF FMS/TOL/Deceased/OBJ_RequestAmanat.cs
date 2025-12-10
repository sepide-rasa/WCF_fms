using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_RequestAmanat
    {
        public int fldId { get; set; }
        public int fldEmployeeId { get; set; }
        public int fldShomareId { get; set; }
        public int fldOrganId { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldSh_Shenasname { get; set; }
        public string fldFatherName { get; set; }
        public string fldMeli_Moshakhase { get; set; }
        public string fldNameVadiSalam { get; set; }
        public string fldNameGhete { get; set; }
        public string fldNameRadif { get; set; }
        public string fldShomare { get; set; }
        public string fldTarikhRequest { get; set; }
        public string fldTitleKartabl { get; set; }
        public Nullable<int> fldKartablId { get; set; }
        public bool ExistsCharkhe { get; set; }
        public int fldGheteId { get; set; }
        public int fldRadifId { get; set; }
        public int fldVadiSalamId { get; set; }
        public string fldCodemeli { get; set; }
        public string fldCodeMoshakhase { get; set; }
        public bool fldIsEbtal { get; set; }
        public string fldIsEbtalName { get; set; }
    }
}