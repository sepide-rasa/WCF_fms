using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_RptCodingTurnover
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public string fldParentTitle { get; set; }
        public Nullable<long> fldBedehkar_t { get; set; }
        public Nullable<long> fldBestankar_t { get; set; }
        public int fldType { get; set; }
        public Nullable<long> fldMande_t { get; set; }
        public string fldTypeName_t { get; set; }
        public int fldDocumentNum { get; set; }
        public string fldDescriptionDocu { get; set; }
        public long fldBedehkar { get; set; }
        public long fldBestankar { get; set; }
        public int fldDocument_HedearId { get; set; }
        public string fldParvande { get; set; }
        public string fldTarikhDocument { get; set; }
    }
}