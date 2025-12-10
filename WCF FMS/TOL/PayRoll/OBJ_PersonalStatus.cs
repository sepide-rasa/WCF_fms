using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_PersonalStatus
    {
        public int fldId { get; set; }
        public int fldStatusId { get; set; }
        public int? fldPrsPersonalInfoId { get; set; }
        public int? fldPayPersonalInfoId { get; set; }
        public string  fldDateTaghirVaziyat { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTitle { get; set; }
    }
}