using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Masoulin
    {
        public int fldId { get; set; }
        public string fldTarikhEjra { get; set; }
        public string fldTitleModule { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldModule_OrganId { get; set; }
        public string fldModule_OrganName { get; set; }
    }
}