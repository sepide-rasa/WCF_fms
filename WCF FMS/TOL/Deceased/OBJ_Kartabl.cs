using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_Kartabl
    {
        public int fldId { get; set; }
        public string fldTitleKartabl { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldOrganId { get; set; }
        public Nullable<int> fldorderid { get; set; }
        public Nullable<bool> fldEbtal { get; set; }
        public Nullable<bool> fldEtmam { get; set; }
        public string fldTitleEbtal { get; set; }
        public string fldTitleEtmam { get; set; }
    }
}