using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Hokm_Item
    {
        public int fldId { get; set; }
        public int fldPersonalHokmId { get; set; }
        public int fldItems_EstekhdamId { get; set; }
        public int fldMablagh { get; set; }
        public decimal fldZarib { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldItemsHoghughiId { get; set; }
        public string fldNameItem_Estekhdam { get; set; }
    }
}