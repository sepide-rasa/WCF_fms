using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_HistoryTahsilat
    {
        public int fldId { get; set; }
        public int fldEmployeeId { get; set; }
        public int fldMadrakId { get; set; }
        public int fldReshteId { get; set; }
        public string fldTarikh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTitleMadrak { get; set; }
        public string fldTitleReshte { get; set; }
    }
    }
