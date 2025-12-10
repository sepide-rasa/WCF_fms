using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Bank
    {
        DL_Bank Bank = new DL_Bank();

        #region Detail
        public OBJ_Bank Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Bank.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Bank> Select(string FieldName, string FilterValue, int h)
        {
            return Bank.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string BankName, byte[] File, string Pasvand, byte? CentralBankCode, string InfinitiveBank, bool Fix, int UserId, string Desc, out ClsError error)
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
            else if (BankName == null|| BankName=="")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام بانک ضروری است";
            }
            else if (InfinitiveBank == null || InfinitiveBank == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه بانک ضروری است";
            }
            else if (BankName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام بانک وارد شده کمتر از حد مجاز می باشد.";
            }
            else if (BankName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام بانک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (InfinitiveBank.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه بانک وارد شده کمتر از حد مجاز می باشد.";
            }
            else if (InfinitiveBank.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه بانک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if(Bank.CheckRepeatedRow(BankName,0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Bank.Insert(BankName, File, Pasvand, CentralBankCode, InfinitiveBank, Fix, UserId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string BankName, int FileId, byte[] File, string Pasvand, byte? CentralBankCode, string InfinitiveBank, bool Fix, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (BankName == null || BankName == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام بانک ضروری است";
            }
            else if (InfinitiveBank == null || InfinitiveBank == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه بانک ضروری است";
            }
            else if (BankName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام بانک وارد شده کمتر از حد مجاز می باشد.";
            }
            else if (BankName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام بانک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (InfinitiveBank.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه بانک وارد شده کمتر از حد مجاز می باشد.";
            }
            else if (InfinitiveBank.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه بانک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Bank.CheckRepeatedRow(BankName, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Bank.Update(Id, BankName, FileId, File, Pasvand, CentralBankCode, InfinitiveBank, Fix, UserId, Desc);

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
                error.ErrorMsg = "کد کاربر ضروری است.";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (Bank.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Bank.Delete(id, userId);
        }
        #endregion
    }
}