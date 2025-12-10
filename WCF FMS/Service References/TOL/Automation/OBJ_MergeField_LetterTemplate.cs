using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_MergeField_LetterTemplate
    {
        public int fldId { get; set; }
        public int fldLetterTamplateId { get; set; }
        public int fldMergeFieldId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldEnName { get; set; }
        public string fldFaName { get; set; }
        public string fldTitleLetter { get; set; }
    }
}