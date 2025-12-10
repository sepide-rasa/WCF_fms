using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_Message
    {
        public int fldId { get; set; }
        public int fldCommisionId { get; set; }
        public string fldTitle { get; set; }
        public string fldMatn { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldOrganId { get; set; }
        public string fldIP { get; set; }
        public string fldTarikhShamsi { get; set; }
    }
}