using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Archive
{
    public class OBJ_ArchiveTree
    {
        public int fldId { get; set; }
        public Nullable<int> fldPID { get; set; }
        public string fldTitle { get; set; }
        public bool fldFileUpload { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public Nullable<int> fldModuleId { get; set; }
        public string fldMaduleName { get; set; }
    }
}