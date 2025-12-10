using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_LetterBox
    {
        public int fldId { get; set; }
        public int fldBoxId { get; set; }
        public long? fldLetterId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldBoxName { get; set; }
        public Nullable<int> fldMessageId { get; set; }
        public string fldTitleMessage { get; set; }
    }
}