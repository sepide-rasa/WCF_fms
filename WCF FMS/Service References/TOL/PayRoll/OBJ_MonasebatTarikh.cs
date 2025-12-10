using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_MonasebatTarikh
    {
        public int fldId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public byte fldDay { get; set; }
        public byte fldMonasebatId { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNameMonasebat { get; set; }
        public string fldNameType { get; set; }
        public bool fldMazaya { get; set; }
    }
}