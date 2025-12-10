using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat
    {
        DL_Mohasebat Mohasebat = new DL_Mohasebat();
        #region Detail
        public OBJ_Mohasebat Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Mohasebat.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat> Select(string FieldName, string FilterValue,string FilterValue2,string FilterValue3, int OrganId, int h)
        {
            return Mohasebat.Select(FieldName, FilterValue,FilterValue2,FilterValue3, OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
             int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat,
            int HaghDarman, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari,
            decimal DarsadBimeSakht, byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, bool Flag, int KhalesPardakhti
            , int Mogharari, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, int HokmId, byte T_Asli, byte T_70, byte T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? VamId, Nullable<int> TedadBime1, Nullable<int> TedadBime2, Nullable<int> TedadBime3, int fldShift, byte HesabTypeId, byte MaliyatType, short fldMeetingCount, byte fldCalcType, byte fldEstelagi, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (FiscalHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد جدول مالیاتی ضروری است";
            }
            else if (MoteghayerHoghoghiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد متغیرهای حقوقی ضروری است";
            }
            else if (HokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم ضروری است";
            }
            else if (T_Asli == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد بیمه شده اصلی ضروری است";
            }
            else if (T_70 == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد بیمه شده بالای 70 سال ضروری است";
            }
            else if (T_60 == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد بیمه شده بالای 60 سال ضروری است";
            }
            else if (OrganId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (HesabTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حساب ضروری است";
            }
            else if (fldCalcType == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع محاسبات ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return 0;
            return Mohasebat.Insert(PersonalId, Year, Month, Karkard, Gheybat, TedadEzafeKar, TedadTatilKar, BaBeytute, BedunBeytute, BimeOmrKarFarma, BimeOmr
                    , BimeTakmilyKarFarma, BimeTakmily, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari, BimeMashaghel, DarsadBimePersonal, DarsadBimeKarFarma
                    , DarsadBimeBikari, DarsadBimeSakht, TedadNobatKari, Mosaede, NobatPardakht, GhestVam, PasAndaz, MashmolBime, fldMashmolBimeNaKhales, MashmolMaliyat, Flag, KhalesPardakhti, Mogharari, Maliyat
                    , FiscalHeaderId, MoteghayerHoghoghiId, HokmId, T_Asli, T_70, T_60,  fldT_BedonePoshesh, HamsareKarmand, Mazad30Sal, VamId, TedadBime1, TedadBime2, TedadBime3, HesabTypeId, MaliyatType, fldMeetingCount,fldCalcType, OrganId, fldShift, fldEstelagi, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
             int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman
            , int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht,
            byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int MashmolMaliyat, bool Flag, int khalesPardakhti, int Mogharari,
            int Maliyat, int fldShift, int UserId, string Desc, out ClsError Error)
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

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat.Update(Id, PersonalId, Year, Month, Karkard, Gheybat, TedadEzafeKar, TedadTatilKar, BaBeytute, BedunBeytute, BimeOmrKarFarma, BimeOmr
                    , BimeTakmilyKarFarma, BimeTakmily, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari, BimeMashaghel, DarsadBimePersonal, DarsadBimeKarFarma
                    , DarsadBimeBikari, DarsadBimeSakht, TedadNobatKari, Mosaede, NobatPardakht, GhestVam, PasAndaz, MashmolBime, MashmolMaliyat, Flag, khalesPardakhti, Mogharari, Maliyat,fldShift, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, byte CalcType, int UserId, out ClsError Error)
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
            else if (Mohasebat.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat.Delete(Id, UserId);
        }
        #endregion
        #region CheckMohasebat
        public List<OBJ_Mohasebat> CheckMohasebat(string FieldName, int PersonalId, byte Mah, short sal, byte nobatpardakht, int OrganId)
        {
            return Mohasebat.CheckMohasebat(FieldName, PersonalId, Mah, sal, nobatpardakht,  OrganId);
        }
        #endregion
        #region DeleteMohasebat
        public string DeleteMohasebat(string FieldName, int PersonalId, byte Mah, short sal, byte nobatpardakht, string CostCenter, string AnvaeEstekhdam, int OrganId, byte CalcType, out ClsError Error)
        {
            Error = new ClsError();
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat.DeleteMohasebat(FieldName, PersonalId, Mah, sal, nobatpardakht,CostCenter,AnvaeEstekhdam, OrganId, CalcType);
        }
        #endregion
        #region CheckShomareHesabPasAndazForMohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabPasAndazForMohasebat(string Year, string Month, byte NobatPardakht, int OrganId, int PersonalId)
        {
            return Mohasebat.CheckShomareHesabPasAndazForMohasebat(Year,Month,NobatPardakht,OrganId,PersonalId);
        }
        #endregion
        #region CheckConflictKarkard_Mohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckConflictKarkard_Mohasebat(short Year, byte Month,
            string costCenter,string anvaEstekhdam,  int OrganId, int PersonalId)
        {
            return Mohasebat.CheckConflictKarkard_Mohasebat(Year, Month, costCenter, anvaEstekhdam,OrganId, PersonalId);
        }
        #endregion
        #region CheckShomareHesabForMohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabForMohasebat(string Year, string Month, byte NobatPardakht, int OrganId, int PersonalId, byte HesabType)
        {
            return Mohasebat.CheckShomareHesabForMohasebat(Year, Month, NobatPardakht, OrganId, PersonalId, HesabType);
        }
        #endregion
        #region CheckMohasebeForDisket
        public bool CheckMohasebeForDisket(short Year, byte Month, int OrganId)
        {
            return Mohasebat.CheckMohasebeForDisket(Year, Month, OrganId);
        }
        #endregion
    }
}