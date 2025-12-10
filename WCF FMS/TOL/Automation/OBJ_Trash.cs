using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Trash
    {
        public Nullable<long> code { get; set; }
        public Nullable<long> fldLetterId { get; set; }
        public string fldOrderId { get; set; }
        public int fldComisionID { get; set; }
        public string fldSubject { get; set; }
        public string fldLetterstatus { get; set; }
        public int fldLetterTypeID { get; set; }
        public string fldAssigmentDate { get; set; }
        public int assigmentid { get; set; }
        public string fldAnswerDate { get; set; }
        public int fldSenderComisionID { get; set; }
        public int? fldImmediacyID { get; set; }
        public string fldLetterDate { get; set; }
        public string fldLetterNumber { get; set; }
        public string fldImmediacyName { get; set; }
        public int fldTrashType { get; set; }
        public Nullable<System.DateTime> fldDelDate { get; set; }
        public Nullable<int> fldMessageId { get; set; }
        public string fldCommision { get; set; }
        public int HaveAttach { get; set; }
        public string LetterRecievers { get; set; }
        public int HaveArchiv { get; set; }
        public string fldLetterType { get; set; }
        public string fldCreatedDate { get; set; }
        public string fldSecurityType { get; set; }
        public string fldDesc { get; set; }
        public string fldKeywords { get; set; }
    }
}