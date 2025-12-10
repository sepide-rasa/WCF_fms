using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_MahdoodiyatMohasebat
    {
        public int fldId { get; set; }
        public string fldAzTarikh { get; set; }
        public string fldTatarikh { get; set; }
        public bool fldNoeKarbar { get; set; }
        public bool fldNoeCodeDaramad { get; set; }
        public bool fldNoeAshkhas { get; set; }
        public bool fldStatus { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldNoeKarbarName { get; set; }
        public string fldNoeCodeDaramadName { get; set; }
        public string fldNoeAshkhasName { get; set; }
        public string fldStatusName { get; set; }
        public string fldTitle { get; set; }
    }
}