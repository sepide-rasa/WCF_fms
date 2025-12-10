using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_TemplateCoding
    {
        public int fldId { get; set; }
        public Nullable<int> fldItemId { get; set; }
        public string fldName { get; set; }
        public string fldPCod { get; set; }
        public int fldMahiyatId { get; set; }
        public string fldCode { get; set; }
        public int fldTempNameId { get; set; }
        public int fldLevelsAccountTypId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIp { get; set; }
        public int fldUserId { get; set; }
        public string fldTemplateName { get; set; }
        public string fldNameItem { get; set; }
        public string fldTitle_Mahiyat { get; set; }
        public string fldName_LevelsAccountingType { get; set; }
        public string fldNameTypeHesab { get; set; }
        public byte fldTypeHesabId { get; set; }
        public string fldDaramadCode { get; set; }
        public string fldCodeBudget { get; set; }
        public Nullable<bool> fldAddChildNode { get; set; }
        public Nullable<int> fldMahiyat_GardeshId { get; set; }
    }
}