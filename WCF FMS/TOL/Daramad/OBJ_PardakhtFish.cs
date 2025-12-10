using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_PardakhtFish
    {
        public int fldId { get; set; }
        public int fldFishId { get; set; }
        public System.DateTime fldDatePardakht { get; set; }
        public int fldNahvePardakhtId { get; set; }
        public string fldTarikh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public Nullable<int> fldPardakhtFiles_DetailId { get; set; }
        public Nullable<System.DateTime> fldDateVariz { get; set; }
        public string fldTarikhVariz { get; set; }
    }
}