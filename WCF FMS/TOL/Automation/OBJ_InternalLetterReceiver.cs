using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_InternalLetterReceiver
    {
        public int fldId { get; set; }
        public Nullable<long> fldLetterId { get; set; }
        public Nullable<int> fldMessageId { get; set; }
        public int fldReceiverComisionID { get; set; }
        public int fldAssignmentStatusID { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldNameAssignmentStatus { get; set; }
    }
}