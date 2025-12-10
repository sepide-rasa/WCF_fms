using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Parametrs
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public bool fldTypeParametr { get; set; }
        public bool fldTypeMablagh { get; set; }
        public Nullable<int> fldTypeEstekhdamId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNoeParametrName { get; set; }
        public string fldNoeMablaghName { get; set; }
        public string TypeEstekhdamName { get; set; }
        public int fldFormulId { get; set; }
        public Nullable<bool> fldActive { get; set; }
        public Nullable<bool> fldPrivate { get; set; }
        public Nullable<byte> fldHesabTypeParam { get; set; }
        public string fldActiveName { get; set; }
        public string fldPrivateName { get; set; }
        public string fldHesabTypeParamName { get; set; }
        public Nullable<byte> fldIsMostamar { get; set; }
        public string fldMostamarName { get; set; }
    }
}