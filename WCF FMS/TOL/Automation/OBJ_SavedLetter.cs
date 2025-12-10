using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_SavedLetter
    {
        public long fldLetterId { get; set; }
        public Nullable<int> fldMessageId { get; set; }
        public string fldOrderId { get; set; }
        public string fldSubject { get; set; }
        public string fldLetterNumber { get; set; }
        public string fldLetterDate { get; set; }
        public string fldCreatedDate { get; set; }
        public string fldLetterStatus { get; set; }
        public string fldImmediacyName { get; set; }
        public string fldLetterType { get; set; }
        public int fldLetterTypeID { get; set; }
        public int? fldImmediacyID { get; set; }
        public int HaveArchiv { get; set; }
        public int HaveAttach { get; set; }
        public string fldSecurityType { get; set; }
        public string fldCommision { get; set; }
        public string LetterRecievers { get; set; }
        public string fldKeywords { get; set; }
        public string fldDesc { get; set; }

    }
}