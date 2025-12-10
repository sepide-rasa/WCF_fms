using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_AkharinHokmSal
    {
        public int fldId { get; set; }
        public int fldPrs_PersonalInfoId { get; set; }
        public string fldTarikhEjra { get; set; }
        public string fldTarikhSodoor { get; set; }
        public string fldTarikhEtmam { get; set; }
        public int fldAnvaeEstekhdamId { get; set; }
        public int fldStatusTaaholId { get; set; }
        public byte fldGroup { get; set; }
        public byte fldMoreGroup { get; set; }
        public string fldShomarePostSazmani { get; set; }
        public byte fldTedadFarzand { get; set; }
        public byte fldTedadAfradTahteTakafol { get; set; }
        public string fldTypehokm { get; set; }
        public string fldShomareHokm { get; set; }
        public bool fldStatusHokm { get; set; }
        public string fldDescriptionHokm { get; set; }
        public string fldCodeShoghl { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldYear { get; set; }
    }
}