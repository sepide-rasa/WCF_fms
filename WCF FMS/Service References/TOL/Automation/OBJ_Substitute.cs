using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WCF_FMS.TOL.Automation
 {
    public class OBJ_Substitute
    {
        public int fldID { get; set; }
        public int fldSenderComisionID { get; set; }
        public int fldReceiverComisionID { get; set; }
        public string fldStartDate { get; set; }
        public string fldEndDate { get; set; }
        public System.TimeSpan fldStartTime { get; set; }
        public System.TimeSpan fldEndTime { get; set; }
        public bool fldIsSigner { get; set; }
        public bool fldShowReceiverName { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
        public int fldOrganId { get; set; }
        public string fldReciverComisionName { get; set; }
        public string fldSenderComisionName { get; set; }
        public string fldStartTime_S { get; set; }
        public string fldEndTime_S { get; set; }
    }
}