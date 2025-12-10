using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_DetailPayeSanavati
    {
        public int fldId { get; set; }
        public int fldPayeSanavatiId { get; set; }
        public byte fldGroh { get; set; }
        public int fldMablagh { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldYear { get; set; }
    }
}