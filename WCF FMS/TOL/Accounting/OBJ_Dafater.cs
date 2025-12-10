using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_Dafater
    {
        public string fldCode { get; set; }
        public string fldTitle { get; set; }
        public Nullable<long> fldBedehkar { get; set; }
        public Nullable<long> fldBestankar { get; set; }
        public int fldDocumentNum { get; set; }
        public string fldTarikhDocument { get; set; }
        public string fldDescriptionDocu { get; set; }
        public Nullable<long> fldMande { get; set; }
    }
}