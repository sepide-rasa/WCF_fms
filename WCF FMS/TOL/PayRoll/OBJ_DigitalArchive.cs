using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_DigitalArchive
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public int fldTreeId { get; set; }
        public string fldNameFile { get; set; }
        public string fldDesc { get; set; }
        public byte[] fldImageFile { get; set; }
        public int? fldUserId { get; set; }
        public System.DateTime? fldDate { get; set; }
        public int? fldScanUserId { get; set; }
        public DateTime? fldScanDate { get; set; }
        public bool? fldBooked { get; set; }
        public bool fldisDeleted { get; set; }
    }
}