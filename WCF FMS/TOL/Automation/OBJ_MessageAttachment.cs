using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_MessageAttachment
    {
        public int fldId { get; set; }
        public int fldMessageId { get; set; }
        public int fldFileId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public string fldTitle { get; set; }
        public Nullable<decimal> fldSize { get; set; }
        public string fldPasvand { get; set; }
    }
}