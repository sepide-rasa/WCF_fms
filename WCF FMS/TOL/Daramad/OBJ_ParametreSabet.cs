using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_ParametreSabet
    {
        public int fldId { get; set; }
        public int fldShomareHesabCodeDaramadId { get; set; }
        public string fldNameParametreFa { get; set; }
        public string fldNameParametreEn { get; set; }
        public bool fldNoe { get; set; }
        public byte fldNoeField { get; set; }
        public bool fldVaziyat { get; set; }
        public Nullable<int> fldComboBaxId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string NoeName { get; set; }
        public string NoeFieldName { get; set; }
        public string fldDaramadTitle { get; set; }
        public string VaziyatName { get; set; }
        public string fldTitle { get; set; }
        public Nullable<int> fldFormulId { get; set; }
        public bool fldTypeParametr { get; set; }
        public string fldNoeParametr { get; set; }
    }
}