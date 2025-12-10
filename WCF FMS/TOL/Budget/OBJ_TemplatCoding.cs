using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_TemplatCoding
    {
        public int fldId { get; set; }
        public Nullable<short> fldLevelId { get; set; }
        public string fldStrhid { get; set; }
        public string fldName { get; set; }
        public string fldPCod { get; set; }
        public string fldCode { get; set; }
        public int fldCodingLevelId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIp { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public int fldTemplatNameId { get; set; }
        public string fldNameTampalte { get; set; }
        public string fldNameCodingLevel { get; set; }
    }
}