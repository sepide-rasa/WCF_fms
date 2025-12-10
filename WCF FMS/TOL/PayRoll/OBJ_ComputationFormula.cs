using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ComputationFormula
    {
        public int fldId { get; set; }
        public bool? fldType { get; set; }
        public string fldFormule { get; set; }
        public int? fldOrganId { get; set; }
        public string fldLibrary { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldAzTarikh { get; set; }
        public string NameOrgan { get; set; }
        public string fldTypeName { get; set; }
    }
}