using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_GozareshatFile
    {
        public int fldId { get; set; }
        public int fldGozareshatId { get; set; }
        public int fldOrganId { get; set; }
        public int fldReportFileId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldOrganName { get; set; }
        public string fldTitle { get; set; }
    }
}