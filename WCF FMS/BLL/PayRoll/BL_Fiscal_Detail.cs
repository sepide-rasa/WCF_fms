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
    public class BL_Fiscal_Detail
    {
        DL_Fiscal_Detail Fiscal_Detail = new DL_Fiscal_Detail();
        #region Detail
        public OBJ_Fiscal_Detail Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Fiscal_Detail.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Fiscal_Detail> Select(string FieldName, string FilterValue, int h)
        {
            return Fiscal_Detail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (FiscalHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مالیات ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Fiscal_Detail.Insert(FiscalHeaderId, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc, out ClsError Error)
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

            else if (FiscalHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مالیات ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Fiscal_Detail.Update(Id, FiscalHeaderId, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
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
            return Fiscal_Detail.Delete(Id, UserId);
        }
        #endregion

        #region Fiscal_Header_DetailInsert
        public string Fiscal_Header_DetailInsert(string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(EffectiveDate))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Fiscal_Detail.Fiscal_Header_DetailInsert(EffectiveDate,DateOfIssue, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
        }
        #endregion
        #region Fiscal_Header_DetailUpdate
        public string Fiscal_Header_DetailUpdate(int Id, string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(EffectiveDate))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Fiscal_Detail.Fiscal_Header_DetailUpdate(Id, EffectiveDate,DateOfIssue, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
        }
        #endregion
        #region Fiscal_Header_DetailDelete
        public string Fiscal_Header_DetailDelete(int Id, int UserId, out ClsError Error)
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
            return Fiscal_Detail.Fiscal_Header_DetailDelete(Id, UserId);
        }
        #endregion
    }
}