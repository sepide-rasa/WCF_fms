using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 
namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptFishHoghoughi_Details
    {
        DL_RptFishHoghoughi_Details FishHoghoughi_Details = new DL_RptFishHoghoughi_Details();
        #region SelectMotalebat_Details
        public List<OBJ_MotalebatDetails> SelectMotalebat_Details(int PersonalId, int AzYear, int TaYear, int NobatPardakht, int UserId, byte TypeHesab, byte CalcType)
        {
            return FishHoghoughi_Details.SelectMotalebat_Details(PersonalId, NobatPardakht, AzYear, TaYear, UserId, TypeHesab, CalcType);
        }
        #endregion
        #region SelectKosourat_Details
        public List<OBJ_MotalebatDetails> SelectKosourat_Details(int PersonalId, int AzYear, int TaYear, int NobatPardakht, int UserId, byte TypeHesab, byte CalcType)
        {
            return FishHoghoughi_Details.SelectKosourat_Details(PersonalId, NobatPardakht, AzYear, TaYear, UserId, TypeHesab, CalcType);
        }
        #endregion
        #region SelectMoavaghe_Details
        public List<OBJ_FishHoghoghi_Moavaghe> SelectMoavaghe_Details(int fldPersonalId, int nobatPardakht, short Year, byte Month, short YearPardakht, byte MonthPardakht,
            int UserId, byte TypeHesab, byte CalcType, byte MoavagheType)
        {
            return FishHoghoughi_Details.SelectMoavaghe_Details(fldPersonalId, nobatPardakht, Year, Month, YearPardakht, MonthPardakht, UserId, TypeHesab, CalcType, MoavagheType);
        }
        #endregion
        #region SelectMotalebat_Moavaghe_Details
        public List<OBJ_MotalebatDetails> SelectMotalebat_Moavaghe_Details(int PersonalId, short Year, byte Month, int NobatPardakht, int UserId, byte TypeHesab, byte CalcType)
        {
            return FishHoghoughi_Details.SelectMotalebat_Moavaghe_Details(PersonalId, NobatPardakht, Year, Month, UserId, TypeHesab, CalcType);
        }
        #endregion
        #region SelectKosourat_Moavaghe_Details
        public List<OBJ_MotalebatDetails> SelectKosourat_Moavaghe_Details(int PersonalId, short Year, byte Month, int NobatPardakht, int UserId, byte TypeHesab, byte CalcType)
        {
            return FishHoghoughi_Details.SelectKosourat_Moavaghe_Details(PersonalId, NobatPardakht, Year, Month, UserId, TypeHesab, CalcType);
        }
        #endregion
    }
}