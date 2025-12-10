using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MoteghayerhayeHoghoghi
    {
        DL_MoteghayerhayeHoghoghi MoteghayerhayeHoghoghi = new DL_MoteghayerhayeHoghoghi();
        #region Detail
        public OBJ_MoteghayerhayeHoghoghi Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MoteghayerhayeHoghoghi.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeHoghoghi> Select(string FieldName, string FilterValue, int h)
        {
            return MoteghayerhayeHoghoghi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat, int HaghDarmanMazad
            , int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, string ItemEstekhdam, bool FoghTalash, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AnvaeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (TypeBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع بیمه ضروری است";
            }
            else if (TarikhEjra == null || TarikhEjra == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (TarikhSodur == null || TarikhSodur == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ صدور ضروری است";
            }
            else if (!r.IsMatch(TarikhEjra))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(TarikhSodur))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (MoteghayerhayeHoghoghi.CheckRepeatedRow(TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "برای تاریخ های اجرا و صدور وارد شده اطلاعات قبلا در سیستم ثبت شده است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhayeHoghoghi.Insert(TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, ZaribEzafeKar, SaatKari, DarsadBimePersonal, DarsadbimeKarfarma, DarsadBimeBikari, DarsadBimeJanbazan, HaghDarmanKarmand, HaghDarmanKarfarma
                    , HaghDarmanDolat, HaghDarmanMazad, HaghDarmanTahteTakaffol, DarsadBimeMashagheleZiyanAvar, MaxHaghDarman, ZaribHoghoghiSal, Hoghogh, FoghShoghl, TafavotTatbigh, FoghVizhe, HaghJazb, Tadil, BarJastegi, Sanavat,ItemEstekhdam,FoghTalash, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat, int HaghDarmanMazad
            , int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, bool FoghTalash, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
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
            else if (AnvaeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (TypeBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع بیمه ضروری است";
            }
            else if (TarikhEjra == null || TarikhEjra == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (TarikhSodur == null || TarikhSodur == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ صدور ضروری است";
            }
            else if (!r.IsMatch(TarikhEjra))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(TarikhSodur))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (MoteghayerhayeHoghoghi.CheckRepeatedRow(TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "برای تاریخ های اجرا و صدور وارد شده اطلاعات قبلا در سیستم ثبت شده است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return MoteghayerhayeHoghoghi.Update(Id, TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, ZaribEzafeKar, SaatKari, DarsadBimePersonal, DarsadbimeKarfarma, DarsadBimeBikari, DarsadBimeJanbazan, HaghDarmanKarmand, HaghDarmanKarfarma
                    , HaghDarmanDolat, HaghDarmanMazad, HaghDarmanTahteTakaffol, DarsadBimeMashagheleZiyanAvar, MaxHaghDarman, ZaribHoghoghiSal, Hoghogh, FoghShoghl, TafavotTatbigh, FoghVizhe, HaghJazb, Tadil, BarJastegi, Sanavat, FoghTalash, UserId, Desc);
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
            else if (MoteghayerhayeHoghoghi.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhayeHoghoghi.Delete(Id, UserId);
        }
        #endregion
        #region CopyMoteghayerhayHoghoghi
        public string CopyMoteghayerhayHoghoghi(string TarikhEjra, string TarikhSodur, int headerId, int userId, string desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (userId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (headerId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد متغیرهای حقوقی ضروری است";
            }
            else if (TarikhEjra == null || TarikhEjra == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (TarikhSodur == null || TarikhSodur == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ صدور ضروری است";
            }
            else if (!r.IsMatch(TarikhEjra))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(TarikhSodur))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (MoteghayerhayeHoghoghi.CheckRepeatedRow_Copy(TarikhEjra, TarikhSodur, headerId))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "برای تاریخ های اجرا و صدور وارد شده اطلاعات قبلا در سیستم ثبت شده است.";
            }
            if (desc == null)
                desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhayeHoghoghi.CopyMoteghayerhayHoghoghi(TarikhEjra, TarikhSodur,headerId,userId,desc);
        }
        #endregion
        #region moteghayerhayeHoghopghi_Zarib
        public List<OBJ_MoteghayerhayeHoghoghi> moteghayerhayeHoghopghi_Zarib(int AnvaeEstekhdamId, int TypeBimeId, string TarikhEjra)
        {
            return MoteghayerhayeHoghoghi.moteghayerhayeHoghopghi_Zarib(AnvaeEstekhdamId, TypeBimeId, TarikhEjra);
        }
        #endregion
    }
}