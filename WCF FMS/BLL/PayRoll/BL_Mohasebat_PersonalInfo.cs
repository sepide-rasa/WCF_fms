using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat_PersonalInfo
    {
        DL_Mohasebat_PersonalInfo Mohasebat_PersonalInfo = new DL_Mohasebat_PersonalInfo();
        #region Detail
        public OBJ_Mohasebat_PersonalInfo Detail(int Id,int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return Mohasebat_PersonalInfo.Detail(Id,UserId);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_PersonalInfo> Select(string FieldName, string FilterValue,int UserId, int h)
        {
            return Mohasebat_PersonalInfo.Select(FieldName, FilterValue,UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, int ChartOrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_PersonalInfo.Insert(MohasebatId, VamId, Ezafe_TatilKariId, MamuriyatId, SayerPardakhthaId, CostCenterId, InsuranceWorkShopId, CodeShoghliBime, TypeBimeId, AnvaEstekhdamId, FiscalHeaderId
                    , MoteghayerHoghoghiId, ShomareHesabId, ShomareBime, ShPasAndazPersonal, ShPasAndazKarFarma, HokmId, TedadBime1, TedadBime2, TedadBime3, T_Asli, T_70, T_60,  fldT_BedonePoshesh, HamsareKarmand, Mazad30Sal, StatusIsargariId, MohasebatEydiId, KomakGheyerNaghdiId, MorakhasiId, ChartOrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat_PersonalInfo.Update(Id, MohasebatId, VamId, Ezafe_TatilKariId, MamuriyatId, SayerPardakhthaId, CostCenterId, InsuranceWorkShopId, CodeShoghliBime, TypeBimeId, AnvaEstekhdamId, FiscalHeaderId
                    , MoteghayerHoghoghiId, ShomareHesabId, ShomareBime, ShPasAndazPersonal, ShPasAndazKarFarma, HokmId, TedadBime1, TedadBime2, TedadBime3, T_Asli, T_70, T_60, HamsareKarmand, Mazad30Sal, StatusIsargariId, MohasebatEydiId, KomakGheyerNaghdiId, MorakhasiId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_PersonalInfo.Delete(Id, UserId);
        }
        #endregion
    }
}