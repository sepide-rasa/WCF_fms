using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_SpecialPermission
    {
        public int fldId { get; set; }
        public int fldUserSelectId { get; set; }
        public int fldChartOrganId { get; set; }
        public int fldOpertionId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNameEmloyee { get; set; }
        public string fldTitleChart { get; set; }
        public string fldTitleOpr { get; set; }
    }
}