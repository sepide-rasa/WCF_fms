using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_TypeOfEmploymentCenter
    {
        DL_TypeOfEmploymentCenter TypeOfEmploymentCenter = new DL_TypeOfEmploymentCenter();
        #region Detail
        public OBJ_TypeOfEmploymentCenter Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return TypeOfEmploymentCenter.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_TypeOfEmploymentCenter> Select(string FieldName, string FilterValue, int h)
        {
            return TypeOfEmploymentCenter.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return TypeOfEmploymentCenter.Insert(Title, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }

            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return TypeOfEmploymentCenter.Update(Id, Title, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (TypeOfEmploymentCenter.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return TypeOfEmploymentCenter.Delete(Id, UserId);
        }
        #endregion
    }
}