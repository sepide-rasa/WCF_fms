using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Chek
{
    public class OBJ_OlgoCheck
    {
        public int fldId { get; set; }
        public int fldIdFile { get; set; }
        public int fldIdBank { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTitle { get; set; }
        public string fldBankName { get; set; }
        public int fldOrganId { get; set; }
    }
}