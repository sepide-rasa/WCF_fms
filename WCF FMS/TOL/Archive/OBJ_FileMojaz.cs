using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Archive
{
    public class OBJ_FileMojaz
    {
        public int fldId { get; set; }
        public int fldArchiveTreeId { get; set; }
        public int fldFormatFileId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldFormatName { get; set; }
        public string fldPassvand { get; set; }
        public string fldTitle { get; set; }
    }
}