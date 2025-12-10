using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_NezamVazife
    {
        DL_NezamVazife NezamVazife = new DL_NezamVazife();

        #region Detail
        public OBJ_NezamVazife Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت نظام وظیفه ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return NezamVazife.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_NezamVazife> Select(string FieldName, string FilterValue, int h)
        {
            return NezamVazife.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = NezamVazife.Select("fldTitle", fldTitle, 0).FirstOrDefault();
            if (q != null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                else if (fldTitle == "")
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "عنوان وضعیت نظام وظیفه ضروری است";
                }
                else if (fldTitle.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldTitle.Length > 50)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return NezamVazife.Insert(fldTitle, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(byte fldId, string fldTitle, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = NezamVazife.Select("fldTitle", fldTitle, 0).FirstOrDefault();
            if (q != null && q.fldId != fldId)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                else if (fldTitle == "")
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "عنوان وضعیت نظام وظیفه ضروری است";
                }
                else if (fldTitle.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldTitle.Length > 50)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return NezamVazife.Update(fldId, fldTitle, userId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(byte id, int userId, out ClsError error)
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
                error.ErrorMsg = "کد وضعیت نظام وظیفه ضروری است";
            }
            else if (NezamVazife.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return NezamVazife.Delete(id, userId);
        }
        #endregion
    }
}