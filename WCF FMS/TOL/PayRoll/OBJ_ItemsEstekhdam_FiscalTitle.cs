using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ItemsEstekhdam_FiscalTitle
    {
        public int fldId { get; set; }
        public int fldItemsHoghughiId { get; set; }
        public int fldTypeEstekhdamId { get; set; }
        public string fldTitle { get; set; }
        public bool fldHasZarib { get; set; }
        public string fldHasZaribName { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTitleItemsHoghughi { get; set; }
        public int flAnvaEstekhdamId { get; set; }
        public string fldAnvaEstekhdamTitle { get; set; }
        public bool? fldMashmul { get; set; }
        public string fldNameDefaultTax { get; set; }
        public Nullable<bool> fldMashmoolDefaultTax { get; set; }
    }
}