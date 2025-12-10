using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Chek
{
    public class OBJ_SodorCheck
    {
        public int fldId { get; set; }
        public int fldIdDasteCheck { get; set; }
        public string fldTarikhVosol { get; set; }
        public string fldDarVajh { get; set; }
        public string fldCodeSerialCheck { get; set; }
        public string fldBabat { get; set; }
        public bool fldBabatFlag { get; set; }
        public long fldMablagh { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldMoshakhaseDasteCheck { get; set; }
        public string fldBankName { get; set; }
        public string TarikhSabt { get; set; }
        public string NameShobe { get; set; }
        public string Name_Family { get; set; }
        public string ShomareMeli { get; set; }
        public string fldShomareHesab { get; set; }
        public int AshkhasId { get; set; }
        public string BabatText { get; set; }
        public string TarikhShamsi { get; set; }
        public string MablaghBeHorof { get; set; }
        public byte fldvaziat { get; set; }
        public string NameVaziat { get; set; }
        public string fldTarikhVaziat { get; set; }
        public int fldOrganId { get; set; }
        public Nullable<int> fldTankhahGroupId { get; set; }
        public Nullable<int> fldFactorId { get; set; }
        public Nullable<int> fldContractId { get; set; }
        public int Check_FactorId { get; set; }
    }
}