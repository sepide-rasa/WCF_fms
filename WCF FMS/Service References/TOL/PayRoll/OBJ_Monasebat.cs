using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Monasebat
    {
        public byte fldId { get; set; }
        public string fldNameMonasebat { get; set; }
        public byte fldMonasebatTypeId { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNameType { get; set; }
        public byte fldMonth { get; set; }
        public byte fldDay { get; set; }
        public bool fldDateType { get; set; }
        public bool fldHoliday { get; set; }
        public bool fldMazaya { get; set; }
        public string fldDateTypeName { get; set; }
        public string fldHolidayName { get; set; }
        public string fldMazayaName { get; set; }
        public string fldTarikh { get; set; }
    }
}