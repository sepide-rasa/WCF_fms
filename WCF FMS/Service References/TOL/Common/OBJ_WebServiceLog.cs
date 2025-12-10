using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_WebServiceLog
    {
        public int fldId { get; set; }
        public string fldMatn { get; set; }
        public string fldUser { get; set; }
        public Nullable<System.DateTime> flddate { get; set; }
    }
}