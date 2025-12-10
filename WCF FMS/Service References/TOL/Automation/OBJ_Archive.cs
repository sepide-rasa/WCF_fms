using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Archive
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public Nullable<int> fldPId { get; set; }
        public int fldOrganId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
    }
}