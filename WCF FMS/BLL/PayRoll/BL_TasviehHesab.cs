using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_TasviehHesab
    {
        DL_TasviehHesab TasviehHesab = new DL_TasviehHesab();
        #region Detail
        public OBJ_TasviehHesab Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه تسویه حساب ضروری است";
            }
            return TasviehHesab.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_TasviehHesab> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            return TasviehHesab.Select(FieldName, FilterValue,FilterValue2, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PrsPersonalInfoId,  string Tarikh, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PrsPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            
            else if (Tarikh == null || Tarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(Tarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!TasviehHesab.ValidDate(PrsPersonalInfoId, Tarikh,0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تسویه کوچکتر است";
            }
            else if (TasviehHesab.ValidDateHistoryEstkhdam(PrsPersonalInfoId, Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "در این تاریخ برای شخص مورد نظر تاریخچه استخدام ثبت شده است";
            }
            else if (TasviehHesab.CheckRepeatedRow(Tarikh, PrsPersonalInfoId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return TasviehHesab.Insert( PrsPersonalInfoId, Tarikh, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int PrsPersonalInfoId, string Tarikh, string Desc, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "کد تسویه حساب ضروری است";
            }
            else if (PrsPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            
            else if (Tarikh == null || Tarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(Tarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (TasviehHesab.CheckRepeatedRow(Tarikh, PrsPersonalInfoId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            else if (!TasviehHesab.ValidDate(PrsPersonalInfoId, Tarikh,Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تسویه کوچکتر است";
            }
            else if (TasviehHesab.ValidDateHistoryEstkhdam(PrsPersonalInfoId, Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "در این تاریخ برای شخص مورد نظر تاریخچه استخدام ثبت شده است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return TasviehHesab.Update(Id, PrsPersonalInfoId, Tarikh, Desc, UserId);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه تسویه حساب ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return TasviehHesab.Delete(Id, UserId);
        }
        #endregion
    }
}