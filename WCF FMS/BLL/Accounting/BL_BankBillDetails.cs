using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_BankBillDetails
    {
        DL_BankBillDetails BankBillDetails = new DL_BankBillDetails();
        #region Detail
        public OBJ_BankBillDetails Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return BankBillDetails.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_BankBillDetails> Select(string FieldName, string FilterValue,string FilterValue2, int h)
        {
            return BankBillDetails.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region SelectBankBill_Tarikh
        public OBJ_BankBill_Tarikh SelectBankBill_Tarikh(int FiscalYearId, int shomareHesabId)
        {
            return BankBillDetails.SelectBankBill_Tarikh(FiscalYearId, shomareHesabId);
        }
        #endregion
        #region BankBillMap
        public string BankBillMap(int BankBillId, int Document_HeaderId,byte Type,string SourceIds, int UserId, string IP, string Desc, out ClsError error)
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
            else if (BankBillId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جدول صورتحساب بانک ضروری است";
            }
            else if (Document_HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سند ضروری است";
            }
            else if (Type == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع تراکنش ضروری است.";
            }
            else if (SourceIds == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پرونده ضروری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return BankBillDetails.BankBillMap(BankBillId, Document_HeaderId, Type, SourceIds, UserId, IP, Desc);
        }
        #endregion
    }
}