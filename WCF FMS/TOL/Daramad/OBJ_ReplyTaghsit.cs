using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_ReplyTaghsit
    {
        public int fldId { get; set; }
        public long fldMablaghNaghdi { get; set; }
        public byte fldTedadAghsat { get; set; }
        public string fldShomareMojavez { get; set; }
        public string fldTarikh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldStatusId { get; set; }
        public byte fldTedadMahAghsat { get; set; }
        public long fldJarimeTakhir { get; set; }
        public Nullable<decimal> fldDarsad { get; set; }
        public string fldDescKarmozd { get; set; }
    }
}