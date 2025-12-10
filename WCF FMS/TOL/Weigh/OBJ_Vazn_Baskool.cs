using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_Vazn_Baskool
    {
        public int fldId { get; set; }
        public int fldPluqeId { get; set; }
        public int fldRananadeId { get; set; }
        public Nullable<byte> fldNoeMasrafId { get; set; }
        public Nullable<int> fldAshkhasId { get; set; }
        public Nullable<int> fldChartOrganEjraeeId { get; set; }
        public Nullable<int> fldLoadingPlaceId { get; set; }
        public System.DateTime fldDateTazin { get; set; }
        public Nullable<int> fldKalaId { get; set; }
        public Nullable<decimal> fldVaznKol { get; set; }
        public Nullable<decimal> fldVaznKhals { get; set; }
        public Nullable<int> fldRemittanceId { get; set; }
        public string fldTarikhVaznKhali { get; set; }
        public int fldBaskoolId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldNameRanande { get; set; }
        public string fldNameKala { get; set; }
        public string fldNamePlace { get; set; }
        public string fldPlaque { get; set; }
        public string fldTarikh_TimeTozin { get; set; }
        public bool fldIsPor { get; set; }
        public string fldIsporName { get; set; }
        public int fldTypeKhodroId { get; set; }
        public string fldNameKhodro { get; set; }
        public string fldNameAshkhas { get; set; }
        public string fldNameChart { get; set; }
        public string fldNameHavale { get; set; }
        public string fldNameMasraf { get; set; }
        public string fldTarfHesab { get; set; }
        public bool fldIsprint { get; set; }
        public bool fldEbtal { get; set; }
        public Nullable<int> fldTedad { get; set; }

        public int fldElamAvarezId { get; set; }
        public int fldFishId { get; set; }
        public Nullable<bool> IsKhali { get; set; }
        public decimal? fldVaznKhali { get; set; }
        public int? fldCountHavale { get; set; }
        public Nullable<decimal> fldBaghimande { get; set; }
        public bool fldTypeMohasebe { get; set; }
        public Nullable<bool> lastHour { get; set; }
    }
}