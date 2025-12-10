using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_BankBillHeader
    {
        DL_BankBillHeader BankBill = new DL_BankBillHeader();
        #region Detail
        public OBJ_BankBillHeader Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return BankBill.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_BankBillHeader> Select(string FieldName, string FilterValue, int h)
        {
            return BankBill.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region SelectMoghayeratBanki
        public List<OBJ_MoghayeratBanki> SelectMoghayeratBanki(string FieldName, int FiscalYearId, string AzTarikh, string TaTarikh, int ShomareHesabId)
        {
            return BankBill.SelectMoghayeratBanki(FieldName, FiscalYearId, AzTarikh, TaTarikh, ShomareHesabId);
        }
        #endregion
        #region CheckCountData
        public bool CheckCountData(int HeaderId)
        {
            return BankBill.CheckCountData(HeaderId);
        }
        #endregion
        #region Insert
        public int Insert(string fldName, int fldPatternId, int fldShomareHesabId, int fldFiscalYearId, string fldJsonFile, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (fldName == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است.";
            }
            else if (fldPatternId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "الگو ضروری است.";
            }
            else if (fldShomareHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب ضروری است.";
            }
            else if (fldFiscalYearId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال مالی ضروری است.";
            }
            else if (fldJsonFile == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "فایل ضروری است.";
            }
            else if (BankBill.CheckRepeatedRow(fldName))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان صورتحساب تکراری است.";
            }
            if (error.ErrorType == true)
                return 0;

            return BankBill.Insert(fldName,fldPatternId, fldShomareHesabId, fldFiscalYearId, fldJsonFile, UserId,IP,Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldPatternId, int fldShomareHesabId, int fldFiscalYearId, string fldJsonFile, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (fldName == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldPatternId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "الگو ضروری است.";
            }
            else if (fldShomareHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب ضروری است.";
            }
            else if (fldFiscalYearId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال مالی ضروری است.";
            }
            else if (fldJsonFile == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = ".فایل ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return BankBill.Update(Id,fldName,fldPatternId,fldShomareHesabId,fldFiscalYearId,fldJsonFile, UserId, IP, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return BankBill.Delete(id, userId);
        }
        #endregion
    }
}