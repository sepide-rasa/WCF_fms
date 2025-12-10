using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_CodingBudje_Detail
    {
        public int fldId { get; set; }
        public Nullable<short> fldLevelId { get; set; }
        public string fldStrhid { get; set; }
        public int fldHeaderId { get; set; }
        public string fldTitle { get; set; }
        public string fldCode { get; set; }
        public string fldOldId { get; set; }
        public Nullable<byte> fldTarh_KhedmatTypeId { get; set; }
        public Nullable<byte> fldEtebarTypeId { get; set; }
        public Nullable<byte> fldMasrafTypeId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public string fldBudCode { get; set; }
        public short fldYear { get; set; }
        public string fldMasrafTTitle { get; set; }
        public string fldEtebarType { get; set; }
        public string fldNameLevel { get; set; }
        public string fldPcode { get; set; }
        public int fldCodeingLevelId { get; set; }
        public string fldCodeBarname { get; set; }
        public string fldTitleBarname { get; set; }
        public string fldCodeMamooriyat { get; set; }
        public string fldTitleMamooriyat { get; set; }        
    }
}