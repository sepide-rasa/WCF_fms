using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_Kartabl_Request
    {
        public int fldId { get; set; }
        public int fldKartablId { get; set; }
        public int fldActionId { get; set; }
        public int fldRequestId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public Nullable<int> fldKartablNextId { get; set; }
    }
}