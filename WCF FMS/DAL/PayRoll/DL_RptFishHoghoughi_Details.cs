using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptFishHoghoughi_Details
    {
        #region SelectMotalebat_Details
        public List<OBJ_MotalebatDetails> SelectMotalebat_Details(int fldPersonalId, int nobatPardakht, int azYear, int taYear, int UserId,byte TypeHesab,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptFishHoghoghi_Motalebat_Details(fldPersonalId, nobatPardakht, azYear, taYear, UserId, TypeHesab,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_MotalebatDetails()
                    {
                        fldHokmId = q.fldHokmId,
                        fldKarkard = q.fldKarkard,
                        fldMablagh = q.fldMablagh,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldMonthPardakht = q.fldMonthPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTitle = q.fldTitle,
                        fldtype = q.fldtype,
                        fldYear = q.fldYear,
                        fldCalcType=q.fldCalcType,
                        fldYearPardakht=q.fldYearPardakht,
                        fldBimeMashmool=q.fldBimeMashmool,
                        fldMaliyatMashmool=q.fldMaliyatMashmool,
                        fldMablaghHokm=q.fldMablaghHokm,
                        fldItemsHoghughiId=q.fldItemsHoghughiId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectKosourat_Details
        public List<OBJ_MotalebatDetails> SelectKosourat_Details(int fldPersonalId, int nobatPardakht, int azYear, int taYear, int UserId, byte HesabType,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptFishHoghoghi_KosuratParam_Bank_Details(fldPersonalId, nobatPardakht, azYear, taYear, UserId, HesabType,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_MotalebatDetails()
                    {
                        fldHokmId = q.fldHokmId,
                        fldKarkard = q.fldKarkard,
                        fldMablagh = q.fldMablagh,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldMonthPardakht = q.fldMonthPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTitle = q.fldTitle,
                        fldtype = q.fldtype,
                        fldYear = q.fldYear,
                        fldYearPardakht=q.fldYearPardakht,
                        fldCalcType=q.fldCalcType,
                        fldBimeMashmool = q.fldBimeMashmool,
                        fldMaliyatMashmool = q.fldMaliyatMashmool,
                        fldMablaghHokm = q.fldMablaghHokm,
                        fldItemsHoghughiId = q.fldItemsHoghughiId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectMoavaghe_Details
        public List<OBJ_FishHoghoghi_Moavaghe> SelectMoavaghe_Details(int fldPersonalId, int nobatPardakht, short Year,byte Month,short YearPardakht,byte MonthPardakht,
            int UserId,byte TypeHesab,byte CalcType,byte MoavagheType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptFishHoghoghi_Moavaghe_Details(fldPersonalId, nobatPardakht, YearPardakht, MonthPardakht,Year,Month, UserId, TypeHesab,
                    Convert.ToByte(CalcType), MoavagheType)
                    .Select(q => new OBJ_FishHoghoghi_Moavaghe()
                    {
                        fldHokmId = q.fldHokmId,
                        fldKarkard = q.fldKarkard,
                        fldMablagh = q.fldMablagh,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonthPardakht = q.fldMonthPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTitle = q.fldTitle,
                        fldtype = q.fldtype,
                        fldYearPardakht = q.fldYearPardakht,
                        fldBimeMashmool = q.fldBimeMashmool,
                        fldMaliyatMashmool = q.fldMaliyatMashmool,
                        fldBimeMashmoolMahAsli=q.fldBimeMashmoolMahAsli,
                        fldBimeMashmoolMoavaghe=q.fldBimeMashmoolMoavaghe,
                        fldMablaghMahAsli=q.fldMablaghMahAsli,
                        fldMablaghMoavaghe=q.fldMablaghMoavaghe,
                        fldMablaghNahaee=q.fldMablaghNahaee,
                        fldMaliyatMashmoolMahAsli=q.fldMaliyatMashmoolMahAsli,
                        fldMaliyatMashmoolMoavaghe=q.fldMaliyatMashmoolMoavaghe,
                        fldMashmolBimeMahAsli=q.fldMashmolBimeMahAsli,
                        fldMashmolBimeMoavaghe=q.fldMashmolBimeMoavaghe,
                        fldMashmolMaliyatMahAsli=q.fldMashmolMaliyatMahAsli,
                        fldMashmolMaliyatMoavaghe=q.fldMashmolMaliyatMoavaghe,
                        fldmonth=q.fldmonth,
                        fldMonthMoavagh=q.fldMonthMoavagh,
                        fldyear=q.fldyear,
                        fldYearMoavagh=q.fldYearMoavagh  
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectMotalebat_Moavaghe_Details
        public List<OBJ_MotalebatDetails> SelectMotalebat_Moavaghe_Details(int fldPersonalId, int nobatPardakht, short Year, byte Month, int UserId, byte TypeHesab,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptFishHoghoghi_Motalebat_Moavaghe_Details(fldPersonalId, nobatPardakht, Year, Month, UserId, TypeHesab,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_MotalebatDetails()
                    {
                        fldHokmId = q.fldHokmId,
                        fldKarkard = q.fldKarkard,
                        fldMablagh = q.fldMablagh,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldMonthPardakht = q.fldMonthPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTitle = q.fldTitle,
                        fldtype = q.fldtype,
                        fldYear = q.fldYear,
                        fldCalcType = q.fldCalcType,
                        fldYearPardakht = q.fldYearPardakht,
                        fldBimeMashmool = q.fldBimeMashmool,
                        fldMaliyatMashmool = q.fldMaliyatMashmool,
                        fldMablaghHokm = q.fldMablaghHokm,
                        fldItemsHoghughiId = q.fldItemsHoghughiId                        
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectKosourat_Moavaghe_Details
        public List<OBJ_MotalebatDetails> SelectKosourat_Moavaghe_Details(int fldPersonalId, int nobatPardakht, short Year, byte Month, int UserId, byte TypeHesab,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptFishHoghoghi_KosuratParam_Bank_Moavaghe_Details(fldPersonalId, nobatPardakht, Year, Month, UserId, TypeHesab,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_MotalebatDetails()
                    {
                        fldHokmId = q.fldHokmId,
                        fldKarkard = q.fldKarkard,
                        fldMablagh = q.fldMablagh,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldMonthPardakht = q.fldMonthPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTitle = q.fldTitle,
                        fldtype = q.fldtype,
                        fldYear = q.fldYear,
                        fldYearPardakht = q.fldYearPardakht,
                        fldCalcType = q.fldCalcType,
                        fldBimeMashmool = q.fldBimeMashmool,
                        fldMaliyatMashmool = q.fldMaliyatMashmool,
                        fldMablaghHokm = q.fldMablaghHokm,
                        fldItemsHoghughiId = q.fldItemsHoghughiId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}