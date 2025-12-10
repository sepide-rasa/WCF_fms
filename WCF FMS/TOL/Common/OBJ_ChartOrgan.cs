using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_ChartOrgan
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public Nullable<int> fldPId { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public byte fldNoeVahed { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNoeVahedName { get; set; }
        public string fldOrganizationName { get; set; }
    }
}