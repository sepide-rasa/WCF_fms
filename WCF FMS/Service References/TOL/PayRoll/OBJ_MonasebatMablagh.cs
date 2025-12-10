using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MonasebatMablagh
    {
        public int fldId { get; set; }
        public int fldHeaderId { get; set; }
        public byte fldMonasebatId { get; set; }
        public int fldMablagh { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNameMonasebat { get; set; }
        public string fldNameType { get; set; }
        public byte fldTypeNesbatId { get; set; }
        public string fldTypeNesbatName { get; set; }
    }
}