using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_State
    {
        DL_State State = new DL_State();

        #region Detail
        public OBJ_State Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد استان ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return State.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_State> Select(string FieldName, string FilterValue, int h)
        {
            return State.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = State.Select("fldName", fldName, 1).FirstOrDefault();
            if (q != null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "استانی با این نام قبلا در سیستم ثبت شده است.";
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
                if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام استان ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 150)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return State.Insert(fldName, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            var q = State.Select("fldName", fldName, 1).FirstOrDefault();
            if (q != null && q.fldId != fldId)
            {
                error.ErrorType = true;
                error.ErrorMsg = "استان با این نام قبلا در سیستم ثبت شده است.";
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
                if (fldId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد استان ضروری است";
                }
                if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام استان ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 150)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return State.Update(fldId, fldName, userId, Desc);

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
                error.ErrorMsg = "کد استان ضروری است";
            }
            else if(State.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return State.Delete(id, userId);
        }
        #endregion
    }
}