using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.AnbarAmval
{
    public class OBJ_InsuranceType
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldOrganId { get; set; }
    }
}