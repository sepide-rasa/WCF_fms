using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Organization
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public Nullable<int> fldPId { get; set; }
        public int fldFileId { get; set; }
        public int fldCityId { get; set; }
        public string fldCityName { get; set; }
        public string fldCodePosti { get; set; }
        public string fldTelphon { get; set; }
        public string fldAddress { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldCodAnformatic { get; set; }
        public byte fldCodKhedmat { get; set; }
        public string fldShenaseMelli { get; set; }
        public string fldCodEghtesadi { get; set; }
        public string fldShomareSabt { get; set; }
        public int fldAshkhaseHoghoghiId { get; set; }
        public string FldNameAshkhaseHoghoghi { get; set; }
        public int fldStateId { get; set; }
    }
}