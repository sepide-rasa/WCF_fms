using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Automation
{
    public class OBJ_SavedMessage
    {
        public string fldTitleMessge { get; set; }
        public string fldMatn { get; set; }
        public string fldtarikh { get; set; }
        public int fldMessageId { get; set; }
        public Nullable<int> fldLetterId { get; set; }
        public int HaveAttach { get; set; }
        public string fldCommision { get; set; }
        public string LetterRecievers { get; set; }
        public string fldDesc { get; set; }
    }
}