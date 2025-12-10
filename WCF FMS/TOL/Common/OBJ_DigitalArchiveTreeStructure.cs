using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_DigitalArchiveTreeStructure
    {
        public int fldId { get; set; }
        public Nullable<int> fldPID { get; set; }
        public Nullable<int> fldModuleId { get; set; }
        public string fldTitle { get; set; }
        public string fldModuleName { get; set; }
        public bool fldAttachFile { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}