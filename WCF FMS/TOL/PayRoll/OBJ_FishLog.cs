using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_FishLog
    {
        public int fldId { get; set; }
        public byte fldType { get; set; }
        public Nullable<int> fldPersonalId { get; set; }
        public int fldOrganId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public byte fldNobatPardakht { get; set; }
        public Nullable<byte> fldFilterType { get; set; }
        public Nullable<byte> fldFishType { get; set; }
        public Nullable<int> fldCostCenterId { get; set; }
        public Nullable<int> fldMahaleKhedmat { get; set; }
        public byte fldCalcType { get; set; }
        public Nullable<byte> fldMostamar { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public string fldQRCode { get; set; }

    }
}