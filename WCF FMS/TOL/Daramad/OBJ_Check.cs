using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_Check
    {
        public int fldId { get; set; }
        public int fldShomareHesabId { get; set; }
        public string fldShomareSanad { get; set; }
        public string fldTarikhSarResid { get; set; }
        public long fldMablaghSanad { get; set; }
        public byte fldStatus { get; set; }
        public bool fldTypeSanad { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldReplyTaghsitId { get; set; }
        public string fldTypeSanadName { get; set; }
        public string fldStatusName { get; set; }
        public int fldShomareHesabIdOrgan { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldShomareHesabOrgan { get; set; }
    }
}