using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_ItemNecessary
    {
        public int fldId { get; set; }
        public string fldNameItem { get; set; }
        public int fldMahiyatId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIp { get; set; }
        public int fldUserId { get; set; }
        public byte fldTypeHesabId { get; set; }
        public string fldNameTypeHesab { get; set; }
        public Nullable<int> fldMahiyat_GardeshId { get; set; }
    }
}