using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_BudgetPayHeader
    {
        DL_BudgetPayHeader BudgetPayHeader = new DL_BudgetPayHeader();
        #region Detail
        public OBJ_BudgetPayHeader Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return BudgetPayHeader.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_BudgetPayHeader> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return BudgetPayHeader.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId,int? fldKosouratId, int fldBudgetCode, int fldUserId, string fldIP, string fldDesc, string fldTypeEstekhdamId, out ClsError Error)
        {
            Error = new ClsError();
            if (fldDesc == null)
                fldDesc = "";

            if (fldFiscalYearId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال مالی ضروری است";
            }


            else if (fldItemsHoghughiId == null && fldParametrId == null && fldKosouratId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم حقوقی ضروری است";
            }
            else if (fldBudgetCode == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بودجه ضروری است";
            }
            else if (fldTypeEstekhdamId == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع استخدام ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return BudgetPayHeader.Insert(fldFiscalYearId,fldItemsHoghughiId,fldParametrId, fldKosouratId,fldBudgetCode,fldUserId,fldIP,fldDesc,  fldTypeEstekhdamId);
        }
        #endregion
        #region Update
        public string Update(int Id, int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId,int? fldKosouratId, int fldBudgetCode, int fldUserId, string fldIP, string fldDesc, string fldTypeEstekhdamId, out ClsError Error)
        {
            Error = new ClsError();
            if (fldFiscalYearId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال مالی ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }

            else if (fldItemsHoghughiId == null && fldParametrId == null && fldKosouratId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم حقوقی ضروری است";
            }
            else if (fldBudgetCode == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بودجه ضروری است";
            }
            else if (fldTypeEstekhdamId == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع استخدام ضروری است";
            }

            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return BudgetPayHeader.Update(Id, fldFiscalYearId,fldItemsHoghughiId,fldParametrId, fldKosouratId,fldBudgetCode,fldUserId,fldIP,fldDesc,  fldTypeEstekhdamId);
        }
        #endregion


        #region Delete
        public string Delete(string FieldName, int ItemId, int FiscalYearId, int UserId, out ClsError Error)
        {
            Error = new ClsError();

            if (ItemId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه آیتم ضروری است";
            }
            else if (FiscalYearId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال مالی ضروری است";
            }
            else if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (FieldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حذف ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return BudgetPayHeader.Delete(FieldName, ItemId,FiscalYearId, UserId);
        }
        #endregion
    }
}