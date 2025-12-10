using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_City
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public int fldStateId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldStateName { get; set; }
        public string fldLatitude { get; set; }
        public string fldLongitude { get; set; }
    }
}