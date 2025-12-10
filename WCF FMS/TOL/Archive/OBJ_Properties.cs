using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Archive
{
    public class OBJ_Properties
    {
        public int fldId { get; set; }
        public int fldType { get; set; }
        public int? fldFormulId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNameFn { get; set; }
        public string fldNameEn { get; set; }
        public string fldTypeName { get; set; }
    }
}