using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_MadrakTahsili
    {

        DL_MadrakTahsili MadrakTahsili = new DL_MadrakTahsili();

        #region Detail
        public OBJ_MadrakTahsili Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدرک تحصیلی ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MadrakTahsili.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MadrakTahsili> Select(string FieldName, string FilterValue, int h)
        {
            return MadrakTahsili.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = MadrakTahsili.Select("fldTitle", fldTitle, 0).FirstOrDefault();
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
                    error.ErrorMsg = "عنوان مدرک تحصیلی ضروری است";
                }
                else if (fldTitle.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان مدرک وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldTitle.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان مدرک وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return MadrakTahsili.Insert(fldTitle, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = MadrakTahsili.Select("fldTitle", fldTitle, 0).FirstOrDefault();
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
                    error.ErrorMsg = "عنوان مدرک تحصیلی ضروری است";
                }
                else if (fldTitle.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان مدرک وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldTitle.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان مدرک وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return MadrakTahsili.Update(fldId, fldTitle, userId, Desc);

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
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدرک تحصیلی ضروری است";
            }
            if (MadrakTahsili.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MadrakTahsili.Delete(id, userId);
        }
        #endregion
    }
}