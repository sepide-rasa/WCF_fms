using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_FormatFile
    {
        public byte fldId { get; set; }
        public string fldFormatName { get; set; }
        public int fldSize { get; set; }
        public string fldPassvand { get; set; }
        public byte[] fldIcon { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldOrganId { get; set; }
    }
}