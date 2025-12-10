using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_DocumentRecord_Details
    {
        public int fldId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserId { get; set; }
        public int fldDocument_HedearId { get; set; }
        public int fldCodingId { get; set; }
        public string fldDescription { get; set; }
        public long fldBedehkar { get; set; }
        public long fldBestankar { get; set; }
        public Nullable<int> fldCenterCoId { get; set; }
        public int? fldCaseId { get; set; }
        public string fldIP { get; set; }
        public int fldSourceId { get; set; }
        public int fldCaseTypeId { get; set; }
        public string fldName { get; set; }
        public string fldNameCenter { get; set; }
        public Nullable<short> fldOrder { get; set; }
        public string fldCode { get; set; }
        public string fldNameCoding { get; set; }
        public string fldName_CodeDetail { get; set; }
        public int fldSerialFish { get; set; }
        public long fldMande { get; set; }
        public string fldNameShakhs { get; set; }
        public int fldElamAvarezId { get; set; }
        public Nullable<int> fldModuleErsalId { get; set; }
        public string fldCaseTypeName { get; set; }
    }
}