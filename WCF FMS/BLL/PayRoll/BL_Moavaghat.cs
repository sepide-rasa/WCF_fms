using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Moavaghat
    {
        DL_Moavaghat Moavaghat = new DL_Moavaghat();
        #region Detail
        public OBJ_Moavaghat Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Moavaghat.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Moavaghat> Select(string FieldName, string FilterValue, int h)
        {
            return Moavaghat.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
            , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, int Maliyat, int? HokmId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
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
                return 0;
            return Moavaghat.Insert(MohasebatId, Year, Month, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari
                    , BimeMashaghel, PasAndaz, MashmolBime, fldMashmolBimeNaKhales, MashmolMaliyat, Maliyat,HokmId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
            , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime, int MashmolMaliyat, int Maliyat, int? HokmId, int UserId, string Desc, out ClsError Error)
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
            else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
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
            return Moavaghat.Update(Id, MohasebatId, Year, Month, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari
                    , BimeMashaghel, PasAndaz, MashmolBime, MashmolMaliyat, Maliyat,HokmId, UserId, Desc);
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
            else if (Moavaghat.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Moavaghat.Delete(Id, UserId);
        }
        #endregion
       
    }
}