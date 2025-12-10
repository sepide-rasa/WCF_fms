using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_Barat
    {
        public int fldId { get; set; }
        public string fldTarikhSarResid { get; set; }
        public string fldShomareSanad { get; set; }
        public int fldReplyTaghsitId { get; set; }
        public long fldMablaghSanad { get; set; }
        public byte fldStatus { get; set; }
        public int fldBaratDarId { get; set; }
        public string fldMakanPardakht { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldStatusName { get; set; }
    }
}