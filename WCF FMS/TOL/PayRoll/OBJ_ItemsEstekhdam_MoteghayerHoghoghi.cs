using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ItemsEstekhdam_MoteghayerHoghoghi
    {
        public int fldId { get; set; }
        public int fldItemsHoghughiId { get; set; }
        public int fldTypeEstekhdamId { get; set; }
        public string fldTitle { get; set; }
        public bool fldHasZarib { get; set; }
        public string fldHasZaribstring { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTitleItemsHoghughi { get; set; }
        public int flAnvaeEstekhdamId { get; set; }
        public string fldAnvaeEstekhdamTitle { get; set; }
        public bool fldMazayaMashmool { get; set; }
    }
}