using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Check
    {
        DL_Check Check = new DL_Check();

        #region Detail
        public OBJ_Check Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Check.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Check> Select(string FieldName, string FilterValue, int h)
        {
            return Check.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(out int fldId,int ShomareHesabId, string ShomareSanad, int ReplyTaghsitId, string TarikhSarResid, long MablaghSanad, byte Status, bool TypeSanad, int ShomareHesabIdOrgan, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (ReplyTaghsitId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پاسخ درخواست تقیسط ضروری است";
            }
            else if (ShomareSanad == "" || ShomareSanad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره سند ضروری است";
            }
            else if (ShomareSanad.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره سند وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShomareSanad.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره سند وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (MablaghSanad == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ سند ضروری است";
            }
            else if (Status > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد وضعیت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Status == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت ضروری است.";
            }
            else if (Check.CheckRepeatedRow(0,ShomareSanad))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره سند وارد شده قبلا در سیستم ثبت شده است.";
            }
            else if (ShomareHesabIdOrgan == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب عمومی ضروری است.";
            }
            if (TypeSanad == false)
            {
                if (TarikhSarResid == "" || TarikhSarResid == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تاریخ سررسید ضروری است";
                }
                if (!r.IsMatch(TarikhSarResid))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (error.ErrorType == true)
            {
                fldId = 0;
                return "خطا";
            }

            return Check.Insert(out fldId,ShomareHesabId, ShomareSanad, ReplyTaghsitId, TarikhSarResid, MablaghSanad, Status, TypeSanad, ShomareHesabIdOrgan, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabId, string ShomareSanad, int ReplyTaghsitId, string TarikhSarResid, long MablaghSanad, byte Status, bool TypeSanad, int ShomareHesabIdOrgan, string DateStatus, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (ShomareSanad == "" || ShomareSanad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره سند ضروری است";
            }
            else if (ReplyTaghsitId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پاسخ درخواست تقیسط ضروری است";
            }
            else if (MablaghSanad == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ سند ضروری است";
            }
            else if (ShomareSanad.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره سند وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShomareSanad.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره سند وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (Status > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد وضعیت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Status == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت ضروری است.";
            }
            else if (ShomareHesabIdOrgan == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب عمومی ضروری است.";
            }
            else if (Check.CheckRepeatedRow(Id, ShomareSanad))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره سند وارد شده قبلا در سیستم ثبت شده است.";
            }
            if (Status != 1)
            {
                if (DateStatus == "" || DateStatus == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تاریخ تغییر وضعیت ضروری است";
                }
                else if (!r.IsMatch(DateStatus))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (TypeSanad == false)
            {
                if (TarikhSarResid == "" || TarikhSarResid == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تاریخ سررسید ضروری است";
                }
                if (!r.IsMatch(TarikhSarResid))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return Check.Update(Id, ShomareHesabId, ShomareSanad, ReplyTaghsitId, TarikhSarResid, MablaghSanad, Status, TypeSanad, ShomareHesabIdOrgan, DateStatus, userId, Desc);

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

            return Check.Delete(id, userId);
        }
        #endregion
        #region UpdateSendToMali_Check
        public string UpdateSendToMali_Check( int id,bool Flag, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Check.UpdateSendToMali_Check(id,Flag);

        }
        #endregion
        #region UpdateReceive_Check
        public string UpdateReceive_Check(int CheckId, int UserId,int Document_HeaderId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (CheckId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (UserId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Document_HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سند ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Check.UpdateReceive_Check(CheckId, UserId, Document_HeaderId);

        }
        #endregion
        #region InsertCheckIntoSanad
        public string InsertCheckIntoSanad(int CheckId,string DocDate, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (CheckId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Check.InsertCheckIntoSanad(CheckId,DocDate, UserId);
        }
        #endregion
    }
}