using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_LetterMinut
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public string fldDescMinut { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldShomareHesabCodeDaramadId { get; set; }
        public bool fldSodoorBadAzVarizNaghdi { get; set; }
        public bool fldSodoorBadAzTaghsit { get; set; }
        public bool fldTanzimkonande { get; set; }
    }
}