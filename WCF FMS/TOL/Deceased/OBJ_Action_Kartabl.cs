using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_Action_Kartabl
    {
        public int fldId { get; set; }
        public int fldActionId { get; set; }
        public int fldKartablId { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldOrganId { get; set; }
        public string fldTitleAction { get; set; }
        public string fldTitleKartabl { get; set; }
    }
}