using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Safte
    {
        DL_Safte Safte = new DL_Safte();

        #region Detail
        public OBJ_Safte Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Safte.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Safte> Select(string FieldName, string FilterValue, int h)
        {
            return Safte.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, int userId, string Desc, out ClsError error)
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
            else if (Status ==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت ضروری است.";
            }
            else if (TarikhSarResid == "" || TarikhSarResid == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ سررسید ضروری است";
            }
            else if (!r.IsMatch(TarikhSarResid))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Safte.CheckRepeatedRow(ShomareSanad, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره سند وارد شده قبلا در سیستم ثبت شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Safte.Insert(TarikhSarResid, ReplyTaghsitId, ShomareSanad, MablaghSanad, Status, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, string DateStatus, int userId, string Desc, out ClsError error)
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
            else if (TarikhSarResid == "" || TarikhSarResid == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ سررسید ضروری است";
            }
            else if (!r.IsMatch(TarikhSarResid))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            
            else if (Safte.CheckRepeatedRow(ShomareSanad, Id))
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
            if (error.ErrorType == true)
                return "خطا";

            return Safte.Update(Id, TarikhSarResid, ReplyTaghsitId, ShomareSanad, MablaghSanad, Status,DateStatus, userId, Desc);

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

            return Safte.Delete(id, userId);
        }
        #endregion
    }
}