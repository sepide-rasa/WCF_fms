using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PardakhtFile
    {
        DL_PardakhtFile PardakhtFile = new DL_PardakhtFile();

        #region Detail
        public OBJ_PardakhtFile Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PardakhtFile.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PardakhtFile> Select(string FieldName, string FilterValue, int h)
        {
            return PardakhtFile.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(int BankId, string FileName, string DateSendFile, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (FileName == "" || FileName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فایل ضروری است";
            }
            else if (FileName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فایل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(DateSendFile))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (DateSendFile == "" || DateSendFile == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ارسال فایل ضروری است";
            }
            else if (BankId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بانک ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return PardakhtFile.Insert(BankId,FileName,DateSendFile, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int BankId, string FileName, string DateSendFile, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (FileName == "" || FileName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فایل ضروری است";
            }
            else if (FileName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فایل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(DateSendFile))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (DateSendFile == "" || DateSendFile == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ارسال فایل ضروری است";
            }
            else if (BankId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بانک ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PardakhtFile.Update(Id, BankId, FileName, DateSendFile, userId, Desc);

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
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PardakhtFile.Delete(id, userId);
        }
        #endregion
    }
}