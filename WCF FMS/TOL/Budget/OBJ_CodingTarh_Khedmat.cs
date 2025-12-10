using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_CodingTarh_Khedmat
    {
        public int fldId { get; set; }
        public int fldCodingBudjeId { get; set; }
        public int fldEtebarTypeId { get; set; }
        public int fldTypeMasrafId { get; set; }
        public int fldOrganId { get; set; }
        public string fldAddress { get; set; }
        public Nullable<int> fldHoghoghiId { get; set; }
        public Nullable<int> fldHaghighiId { get; set; }
        public short fldStartYear { get; set; }
        public short fldEndYear { get; set; }
        public int fldValue { get; set; }
        public long fldPriceVahed { get; set; }
        public long fldKolEtebar { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldTitleEtebar { get; set; }
        public string fldTitleMasraf { get; set; }
        public string NameOperator { get; set; }
    }
}