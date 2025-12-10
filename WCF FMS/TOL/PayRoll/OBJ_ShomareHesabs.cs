using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ShomareHesabs
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public int fldBankFixId { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldShomareKart { get; set; }
        public string fldTypeHesab { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldSh_Personali { get; set; }
        public string fldName { get; set; }
        public string fldTypeHesabName { get; set; }
        public string fldBankName { get; set; }
        public int fldShobeId { get; set; }
        public Nullable<byte> fldHesabTypeId { get; set; }


        public string fldCodemeli { get; set; }
        public int fldPrs_PersonalInfoId { get; set; }
        public int fldShomareHesabId { get; set; }
        public string fldShobeName { get; set; }
    }
}