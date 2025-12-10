using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_Mokatebat
    {
        public int fldId { get; set; }
        public int fldCodhayeDaramadiElamAvarezId { get; set; }
        public int fldFileId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldSharheCodeDaramad { get; set; }
        public int fldElamAvarezId { get; set; }
    }
}