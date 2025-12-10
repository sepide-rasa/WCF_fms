using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Masoulin_DetailList
    {
        public Nullable<int> fldId { get; set; }
        public Nullable<int> fldEmployeeId { get; set; }
        public string fldNameEmployee { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public string fldNameOrgan { get; set; }
        public Nullable<int> fldOrderId { get; set; }
        public Nullable<int> fldMasuolinId { get; set; }
    }
}