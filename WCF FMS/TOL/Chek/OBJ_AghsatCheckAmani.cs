using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Chek
{
    public class OBJ_AghsatCheckAmani
    {
        public int fldId { get; set; }
        public long fldMablagh { get; set; }
        public string fldTarikh { get; set; }
        public string fldNobat { get; set; }
        public byte? fldVaziat { get; set; }
        public int fldIdCheckHayeVarede { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string NameVaziat { get; set; }
        public string fldTarikhVaziat { get; set; }
        public int fldOrganId { get; set; }
    }
}