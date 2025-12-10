using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_CostCenter
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public int fldReportTypeId { get; set; }
        public int fldTypeOfCostCenterId { get; set; }
        public int fldEmploymentCenterId { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldReportTypeName { get; set; }
        public string EmploymentName { get; set; }
        public string TypecenterTitle { get; set; }
        public Nullable<int> fldorganid { get; set; }
    }
}