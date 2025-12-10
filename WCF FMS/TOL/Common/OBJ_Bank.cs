using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Bank
    {
        public int fldId { get; set; }
        public string fldBankName { get; set; }
        public int fldFileId { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public Nullable<byte> fldCentralBankCode { get; set; }
        public string fldInfinitiveBank { get; set; }
        public bool fldFix { get; set; }
        public string fldFixTitle { get; set; }
    }
}