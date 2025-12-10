using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Fiscal_Header
    {
        DL_Fiscal_Header Fiscal_Header = new DL_Fiscal_Header();
        #region Detail
        public OBJ_Fiscal_Header Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Fiscal_Header.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Fiscal_Header> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return Fiscal_Header.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region Insert
        public int Insert(string EffectiveDate, string DateOfIssue, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (EffectiveDate == null || EffectiveDate == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (DateOfIssue == null || DateOfIssue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ صدور ضروری است";
            }
            else if (!r.IsMatch(EffectiveDate))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!r.IsMatch(DateOfIssue))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (Fiscal_Header.CheckRepeatedRow(EffectiveDate, DateOfIssue, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return 0;
            return Fiscal_Header.Insert(EffectiveDate, DateOfIssue, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string EffectiveDate, string DateOfIssue, int UserId, string Desc, out ClsError Error)
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

            else if (EffectiveDate == null || EffectiveDate == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (DateOfIssue == null || DateOfIssue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ صدور ضروری است";
            }
            else if (!r.IsMatch(EffectiveDate))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!r.IsMatch(DateOfIssue))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (Fiscal_Header.CheckRepeatedRow(EffectiveDate, DateOfIssue, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Fiscal_Header.Update(Id, EffectiveDate, DateOfIssue, UserId, Desc);
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
            else if (Fiscal_Header.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Fiscal_Header.Delete(Id, UserId);
        }
        #endregion
    }
}