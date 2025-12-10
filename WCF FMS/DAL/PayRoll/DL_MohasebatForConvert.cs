using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MohasebatForConvert
    {
        #region Insert
        public int Insert(OBJ_Mohasebat Mohasebat, OBJ_Mohasebat_PersonalInfo Mohasebat_PersonalInfo, int ChartOrganId, int fldShift, int fldUserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_InsertMohasebatForConvert(Id,Mohasebat.fldPersonalId, Mohasebat.fldYear, Mohasebat.fldMonth, Mohasebat.fldKarkard, Mohasebat.fldGheybat, Mohasebat.fldTedadEzafeKar, Mohasebat.fldTedadTatilKar, Mohasebat.fldBaBeytute, Mohasebat.fldBedunBeytute, Mohasebat.fldBimeOmrKarFarma, Mohasebat.fldBimeOmr, Mohasebat.fldBimeTakmilyKarFarma
                    , Mohasebat.fldBimeTakmily, Mohasebat.fldHaghDarmanKarfFarma, Mohasebat.fldHaghDarmanDolat, Mohasebat.fldHaghDarman, Mohasebat.fldBimePersonal, Mohasebat.fldBimeKarFarma, Mohasebat.fldBimeBikari, Mohasebat.fldBimeMashaghel, Mohasebat.fldDarsadBimePersonal, Mohasebat.fldDarsadBimeKarFarma,
                    Mohasebat.fldDarsadBimeBikari, Mohasebat.fldDarsadBimeSakht, Mohasebat.fldTedadNobatKari, Mohasebat.fldMosaede, Mohasebat.fldNobatPardakht, Mohasebat.fldGhestVam, Mohasebat.fldPasAndaz, Mohasebat.fldMashmolBime, Mohasebat.fldMashmolMaliyat, Mohasebat.fldFlag, Mohasebat.fldMogharari, Mohasebat.fldMaliyat,
                    Mohasebat_PersonalInfo.fldVamId, Mohasebat_PersonalInfo.fldEzafe_TatilKariId, Mohasebat_PersonalInfo.fldMamuriyatId, Mohasebat_PersonalInfo.fldSayerPardakhthaId, Mohasebat_PersonalInfo.fldCostCenterId, Mohasebat_PersonalInfo.fldInsuranceWorkShopId, Mohasebat_PersonalInfo.fldCodeShoghliBime, Mohasebat_PersonalInfo.fldTypeBimeId, Mohasebat_PersonalInfo.fldAnvaEstekhdamId, Mohasebat_PersonalInfo.fldFiscalHeaderId, Mohasebat_PersonalInfo.fldMoteghayerHoghoghiId,
                    Mohasebat_PersonalInfo.fldShomareHesabId, Mohasebat_PersonalInfo.fldShomareBime, Mohasebat_PersonalInfo.fldShPasAndazPersonal, Mohasebat_PersonalInfo.fldShPasAndazKarFarma, Mohasebat_PersonalInfo.fldHokmId, Mohasebat_PersonalInfo.fldTedadBime1, Mohasebat_PersonalInfo.fldTedadBime2, Mohasebat_PersonalInfo.fldTedadBime3, Mohasebat_PersonalInfo.fldT_Asli, Mohasebat_PersonalInfo.fldT_70, Mohasebat_PersonalInfo.fldT_60, Mohasebat_PersonalInfo.fldHamsareKarmand, Mohasebat_PersonalInfo.fldMazad30Sal,
             Mohasebat_PersonalInfo.fldMohasebatEydiId, Mohasebat_PersonalInfo.fldKomakGheyerNaghdiId, Mohasebat_PersonalInfo.fldStatusIsargariId, Mohasebat_PersonalInfo.fldMorakhasiId, Mohasebat_PersonalInfo.fldOrganId, fldUserId, Mohasebat.fldDesc, ChartOrganId, fldShift);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
    }
}