using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_HokmReport
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public int fldFileId { get; set; }
        public int fldAnvaEstekhdamId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldAnvaEstekhdamName { get; set; }
    }
}