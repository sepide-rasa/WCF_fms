using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_PersonalHokm
    {
        public int fldId { get; set; }
        public string fldTarikhEjra { get; set; }
        public string fldTarikhSodoor { get; set; }
        public string fldTarikhEtmam { get; set; }
        public int fldAnvaeEstekhdamId { get; set; }
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
        public int fldPrs_PersonalInfoId { get; set; }
        public string fldStatusHokmName { get; set; }
        public string fldStatusTaaholName { get; set; }
        public string fldNoeEstekhdamName { get; set; }
        public string fldNameEmployee { get; set; }
        public string fldCodemeli { get; set; }
        public int fldEmployeeId { get; set; }
        public string fldTarikhEstekhdam { get; set; }
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldFatherName { get; set; }
        public string fldSh_Shenasname { get; set; }
        public Nullable<int> fldTaaholId { get; set; }
        public Nullable<int> fldFileId { get; set; }
        public int fldStatusTaaholId { get; set; }
        public int fldMashmooleBime { get; set; }
        public int fldTatbigh1 { get; set; }
        public int fldTatbigh2 { get; set; }
        public bool fldHasZaribeTadil { get; set; }
        public short fldZaribeSal1 { get; set; }
        public short fldZaribeSal2 { get; set; }
        public Nullable<long> fldSumItem { get; set; }
        public string fldSh_Personali { get; set; }
        public string fldTarikhShoroo { get; set; }
        public byte fldHokmType { get; set; }
        public string fldHokmTypeName { get; set; }
    }
}