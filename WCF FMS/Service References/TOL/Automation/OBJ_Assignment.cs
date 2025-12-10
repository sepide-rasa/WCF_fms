using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Assignment
    {
        public int fldID { get; set; }
        public Nullable<long> fldLetterID { get; set; }
        public Nullable<int> fldMessageId { get; set; }
        public string fldAssignmentDate { get; set; }
        public string fldAnswerDate { get; set; }
        public Nullable<int> fldSourceAssId { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public string fldTitleMessage { get; set; }
        public string fldSubject { get; set; }
    }
}