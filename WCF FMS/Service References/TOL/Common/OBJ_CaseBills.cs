using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_CaseBills
    {
        public int fldId { get; set; }
        public int fldBillsTypeId { get; set; }
        public int fldFileNum { get; set; }
        public int fldCentercoId { get; set; }
        public int fldOrganId { get; set; }
        public int fldOrganChartId { get; set; }
        public int? fldAshkhasId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public string fldName_BillsType { get; set; }
        public string fldNameCenter { get; set; }
        public string fldName_shakhs { get; set; }
        public string fldCodeMelli { get; set; }
        public string fldTitle_chartOrgan { get; set; }
        public string fldName_Organ { get; set; }
        public string fldShakhs_Type { get; set; }
    }
}