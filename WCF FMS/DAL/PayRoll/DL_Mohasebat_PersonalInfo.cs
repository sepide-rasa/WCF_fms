using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohasebat_PersonalInfo
    {
        #region Detail
        public OBJ_Mohasebat_PersonalInfo Detail(int Id,int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_PersonalInfoSelect("fldId", Id.ToString(),UserId, 1)
                    .Select(q => new OBJ_Mohasebat_PersonalInfo()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAnvaEstekhdamId=q.fldAnvaEstekhdamId,
                        fldCodeShoghliBime=q.fldCodeShoghliBime,
                        fldCostCenterId=q.fldCostCenterId,
                        fldEzafe_TatilKariId=q.fldEzafe_TatilKariId,
                        fldFiscalHeaderId=q.fldFiscalHeaderId,
                        fldHamsareKarmand=q.fldHamsareKarmand,
                        fldHokmId=q.fldHokmId,
                        fldInsuranceWorkShopId=q.fldInsuranceWorkShopId,
                        fldMamuriyatId=q.fldMamuriyatId,
                        fldMazad30Sal=q.fldMazad30Sal,
                        fldMohasebatId=q.fldMohasebatId,
                        fldMoteghayerHoghoghiId=q.fldMoteghayerHoghoghiId,
                        fldSayerPardakhthaId=q.fldSayerPardakhthaId,
                        fldShomareBime=q.fldShomareBime,
                        fldShomareHesabId=q.fldShomareHesabId,
                        fldShPasAndazKarFarma=q.fldShPasAndazKarFarma,
                        fldShPasAndazPersonal=q.fldShPasAndazPersonal,
                        fldStatusIsargariId=q.fldStatusIsargariId,
                        fldT_60=q.fldT_60,
                        fldT_70=q.fldT_70,
                        fldT_Asli=q.fldT_Asli,
                        fldTedadBime1=q.fldTedadBime1,
                        fldTedadBime2=q.fldTedadBime2,
                        fldTedadBime3=q.fldTedadBime3,
                        fldTypeBimeId=q.fldTypeBimeId,
                        fldVamId = q.fldVamId,
                        fldMohasebatEydiId = q.fldMohasebatEydiId,
                        fldKomakGheyerNaghdiId = q.fldKomakGheyerNaghdiId,
                        fldOrganId = q.fldOrganId,
                        fldMorakhasiId = q.fldMorakhasiId,
                        fldT_BedonePoshesh=q.fldT_BedonePoshesh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_PersonalInfo> Select(string FieldName, string FilterValue,int UserId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_PersonalInfoSelect(FieldName, FilterValue, UserId, h)
                    .Select(q => new OBJ_Mohasebat_PersonalInfo()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAnvaEstekhdamId = q.fldAnvaEstekhdamId,
                        fldCodeShoghliBime = q.fldCodeShoghliBime,
                        fldCostCenterId = q.fldCostCenterId,
                        fldEzafe_TatilKariId = q.fldEzafe_TatilKariId,
                        fldFiscalHeaderId = q.fldFiscalHeaderId,
                        fldHamsareKarmand = q.fldHamsareKarmand,
                        fldHokmId = q.fldHokmId,
                        fldInsuranceWorkShopId = q.fldInsuranceWorkShopId,
                        fldMamuriyatId = q.fldMamuriyatId,
                        fldMazad30Sal = q.fldMazad30Sal,
                        fldMohasebatId = q.fldMohasebatId,
                        fldMoteghayerHoghoghiId = q.fldMoteghayerHoghoghiId,
                        fldSayerPardakhthaId = q.fldSayerPardakhthaId,
                        fldShomareBime = q.fldShomareBime,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShPasAndazKarFarma = q.fldShPasAndazKarFarma,
                        fldShPasAndazPersonal = q.fldShPasAndazPersonal,
                        fldStatusIsargariId = q.fldStatusIsargariId,
                        fldT_60 = q.fldT_60,
                        fldT_70 = q.fldT_70,
                        fldT_Asli = q.fldT_Asli,
                        fldTedadBime1 = q.fldTedadBime1,
                        fldTedadBime2 = q.fldTedadBime2,
                        fldTedadBime3 = q.fldTedadBime3,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldVamId = q.fldVamId,
                        fldMohasebatEydiId = q.fldMohasebatEydiId,
                        fldKomakGheyerNaghdiId = q.fldKomakGheyerNaghdiId,
                        fldOrganId = q.fldOrganId,
                        fldMorakhasiId = q.fldMorakhasiId,
                        fldT_BedonePoshesh = q.fldT_BedonePoshesh
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, int ChartOrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_PersonalInfoInsert(MohasebatId, VamId, Ezafe_TatilKariId, MamuriyatId, SayerPardakhthaId, CostCenterId, InsuranceWorkShopId, CodeShoghliBime, TypeBimeId, AnvaEstekhdamId, FiscalHeaderId
                    , MoteghayerHoghoghiId, ShomareHesabId, ShomareBime, ShPasAndazPersonal, ShPasAndazKarFarma, HokmId, TedadBime1, TedadBime2, TedadBime3, T_Asli, T_70, T_60, HamsareKarmand, Mazad30Sal, StatusIsargariId, MohasebatEydiId, KomakGheyerNaghdiId, MorakhasiId, UserId, Desc, ChartOrganId, fldT_BedonePoshesh);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_PersonalInfoUpdate(Id, MohasebatId, VamId, Ezafe_TatilKariId, MamuriyatId, SayerPardakhthaId, CostCenterId, InsuranceWorkShopId, CodeShoghliBime, TypeBimeId, AnvaEstekhdamId, FiscalHeaderId
                    , MoteghayerHoghoghiId, ShomareHesabId, ShomareBime, ShPasAndazPersonal, ShPasAndazKarFarma, HokmId, TedadBime1, TedadBime2, TedadBime3, T_Asli, T_70, T_60, HamsareKarmand, Mazad30Sal, StatusIsargariId, MohasebatEydiId, KomakGheyerNaghdiId, MorakhasiId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_PersonalInfoDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}