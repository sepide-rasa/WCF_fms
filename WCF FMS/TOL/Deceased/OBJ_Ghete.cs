using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_Ghete
    {
        public int fldId { get; set; }
        public int fldVadiSalamId { get; set; }
        public string fldNameGhete { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string NameVadiSalam { get; set; }
        public int fldorganid { get; set; }
        public bool ExistsRecored { get; set; }
        public Nullable<int> CountRadif { get; set; }
        public Nullable<int> CountShomare { get; set; }


        public string Ghete { get; set; }
    }
}