using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Signer
    {
        public int fldId { get; set; }
        public long fldLetterId { get; set; }
        public int fldSignerComisionId { get; set; }
        public int fldIndexerId { get; set; }
        public int? fldFirstSigner { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldTitlePost { get; set; }
        public Nullable<int> fldFileSignId { get; set; }
    }
}