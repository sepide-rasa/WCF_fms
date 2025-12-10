using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Plaque
    {
        public int fldId { get; set; }
        public byte fldSerialPlaque { get; set; }
        public string fldPlaque { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldSerial_Plaque { get; set; }
    }
}