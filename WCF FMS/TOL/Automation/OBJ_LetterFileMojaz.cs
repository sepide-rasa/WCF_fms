using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_LetterFileMojaz
    {
        public int fldId { get; set; }
        public int fldFormatFileId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public byte fldType { get; set; }
        public string fldTypeName { get; set; }
        public int fldSize { get; set; }
        public string fldPassvand { get; set; }
    }
}