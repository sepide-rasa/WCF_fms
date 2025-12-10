using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_Shomare
    {
        public int fldId { get; set; }
        public int fldRadifId { get; set; }
        public string fldShomare { get; set; }
        public byte fldTedadTabaghat { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNameRadif { get; set; }
        public int fldOrganId { get; set; }
    }
}