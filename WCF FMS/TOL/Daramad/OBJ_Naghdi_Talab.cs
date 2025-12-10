using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_Naghdi_Talab
    {
        public int fldId { get; set; }
        public long fldMablagh { get; set; }
        public int fldReplyTaghsitId { get; set; }
        public byte fldType { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTypeName { get; set; }
        public Nullable<int> fldFishId { get; set; }
        public int? fldShomareHesabId { get; set; }
    }
}