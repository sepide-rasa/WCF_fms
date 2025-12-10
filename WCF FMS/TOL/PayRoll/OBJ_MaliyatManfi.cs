using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MaliyatManfi
    {
        public int fldId { get; set; }
        public int fldMablagh { get; set; }
        public int fldMohasebeId { get; set; }
        public short fldSal { get; set; }
        public byte fldMah { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}