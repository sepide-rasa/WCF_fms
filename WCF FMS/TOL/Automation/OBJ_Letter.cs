using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Letter
    {
        public long fldID { get; set; }
        public int fldYear { get; set; }
        public long fldOrderId { get; set; }
        public string fldSubject { get; set; }
        public string fldLetterNumber { get; set; }
        public string fldLetterDate { get; set; }
        public string fldCreatedDate { get; set; }
        public string fldKeywords { get; set; }
        public Nullable<int> fldLetterStatusID { get; set; }
        public int fldComisionID { get; set; }
        public int fldImmediacyID { get; set; }
        public string fldMatnLetter { get; set; }
        public int fldSecurityTypeID { get; set; }
        public int fldLetterTypeID { get; set; }
        public byte fldSignType { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public System.DateTime fldCreatedDateEn { get; set; }
        public string fldLetterStatusName { get; set; }
        public string fldImmediacyName { get; set; }
        public string fldLetterTypeName { get; set; }
        public string fldSecurityTypeName { get; set; }
        public string fldSenderName { get; set; }
        public string fldRecieverName { get; set; }
        public string fldRoonevesht { get; set; }
        public string fldSigner { get; set; }
        public string fldReceiver { get; set; }
        public string fldSignerName { get; set; }
        public string fldExternalSender { get; set; }
        public string fldExternalSenderName { get; set; }
        public Nullable<int> fldLetterTemplateId { get; set; }
        public Nullable<int> fldContentFileID { get; set; }
        public string fldFont { get; set; }
    }
}