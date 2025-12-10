using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_Coding_Details
    {
        public int fldId { get; set; }
        public string fldPCod { get; set; }
        public int? fldTempCodingId { get; set; }
        public string fldTitle { get; set; }
        public string fldCode { get; set; }
        public int fldAccountLevelId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIp { get; set; }
        public int fldUserId { get; set; }
        public int fldMahiyatId { get; set; }
        public int fldHeaderCodId { get; set; }
        public string fldName_TemplateCoding { get; set; }
        public string fldName_AccountingLevel { get; set; }
        public short fldYear { get; set; }
        public int fldOrganId { get; set; }
        public int fldTempNameId { get; set; }
        public int fldAccountingTypeId { get; set; }
        public byte fldTypeHesabId { get; set; }
        public string fldNameTypeHesab { get; set; }
        public string fldDaramadCode { get; set; }
        public int fldItemIdParent { get; set; }
        public int lastNode { get; set; }
        public Nullable<int> fldMahiyat_GardeshId { get; set; }
        public Nullable<int> fldItemId { get; set; }
    }
}