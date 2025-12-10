using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_BaskolDocument
    {
        public int fldId { get; set; }
        public int fldTozinId { get; set; }
        public int fldFileId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldPasvand { get; set; }
    }
}