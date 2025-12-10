using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_PersonalSign
    {
        public int fldId { get; set; }
        public int fldFileId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldCommitionId { get; set; }
        public Nullable<bool> fldIsEdit { get; set; }
    }
}