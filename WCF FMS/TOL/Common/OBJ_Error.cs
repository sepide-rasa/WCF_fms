using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Error
    {
        public int fldId { get; set; }
        public string fldUserName { get; set; }
        public string fldMatn { get; set; }
        public string fldTarikh { get; set; }
        public string fldIP { get; set; }
        public int? fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}