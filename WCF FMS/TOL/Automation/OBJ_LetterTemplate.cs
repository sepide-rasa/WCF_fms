using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_LetterTemplate
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public bool fldIsBackGround { get; set; }
        public Nullable<int> fldFileId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldBackGroundName { get; set; }
        public string fldNameMergeField { get; set; }
        public string fldIdMergeField { get; set; }
        public string fldFormat { get; set; }
        public string fldEnNameMergeField { get; set; }
        public Nullable<int> fldLetterFileId { get; set; }
         
    }
}