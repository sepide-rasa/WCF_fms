using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_City
    {
        DL_City City = new DL_City();

        #region Detail
        public OBJ_City Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شهر ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return City.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_City> Select(string FieldName, string FilterValue, int h)
        {
            return City.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldStateId, string fldLatitude, string fldLongitude, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = City.Select("fldName", fldName, 0).Where(k => k.fldStateId == fldStateId).FirstOrDefault();
            if (q != null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شهر با این نام در استان مورد نظر قبلا در سیستم ثبت شده است.";
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
                if (fldStateId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد استان ضروری است";
                }
                if (fldName == ""||fldName==null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام شهر ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام شهر وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 150)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام شهر وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return City.Insert(fldName,fldStateId,fldLatitude,fldLongitude, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int fldStateId, string fldLatitude, string fldLongitude, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            var q = City.Select("fldName", fldName, 0).Where(k => k.fldStateId == fldStateId).FirstOrDefault();
            if (q != null && q.fldId != fldId)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شهر با این نام در استان مورد نظر قبلا در سیستم ثبت شده است.";
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
                if (fldStateId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد استان ضروری است";
                }
                if (fldId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد شهر ضروری است";
                }
                if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام شهر ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام شهر وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 150)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام شهر وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return City.Update(fldId, fldName, fldStateId,fldLatitude,fldLongitude, userId, Desc);

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
                error.ErrorMsg = "کد شهر ضروری است";
            }
            else if (City.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return City.Delete(id, userId);
        }
        #endregion
    }
}