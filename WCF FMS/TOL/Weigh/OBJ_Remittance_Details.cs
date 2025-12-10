using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_Remittance_Details
    {
        public int fldId { get; set; }
        public int fldRemittanceId { get; set; }
        public int fldKalaId { get; set; }
        public string fldMaxTon { get; set; }
        public bool fldControlLimit { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldKalaName { get; set; }
        public string fldTitleHeader { get; set; }
        public int fldExistsVazn { get; set; }
    }
}