using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_TypeReport
    {
        public byte fldId { get; set; }
        public byte fldType { get; set; }
        public int fldOrganId { get; set; }
        public int fldBaskoolId { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public string fldTypeName { get; set; }
    }
}