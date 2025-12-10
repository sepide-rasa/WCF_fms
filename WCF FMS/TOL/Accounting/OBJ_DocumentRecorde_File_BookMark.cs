using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_DocumentRecorde_File_BookMark
    {
        public int fldId { get; set; }
        public byte[] fldImage { get; set; }
        public string fldPasvand { get; set; }
        public Nullable<int> fldArchiveTreeId { get; set; }
        public Nullable<bool> fldIsBookMark { get; set; }
        public string fldTitle { get; set; }

    }
}