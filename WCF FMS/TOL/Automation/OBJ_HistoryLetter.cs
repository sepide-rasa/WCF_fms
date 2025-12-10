using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_HistoryLetter
    {
        public int fldId { get; set; }
        public long fldCurrentLetter_Id { get; set; }
        public int fldHistoryType_Id { get; set; }
        public long fldHistoryLetter_Id { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldSubject { get; set; }
        public string fldLetterNumber { get; set; }
        public long fldCreatedLetterId { get; set; }
        public string fldLetterDate { get; set; }
        public int fldComisionID { get; set; }
        public string fldHistoryTypeName { get; set; }
    }
}