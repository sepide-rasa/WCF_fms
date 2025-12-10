using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ExternalFish
    {
        DL_ExternalFish ExternalFish = new DL_ExternalFish();

        #region Detail
        public OBJ_ExternalFish Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ExternalFish.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ExternalFish> Select(string FieldName, string FilterValue, int h)
        {
            return ExternalFish.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string NameCompany, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (NameCompany == "" || NameCompany == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (NameCompany.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شرکت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameCompany.Length > 350)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شرکت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ExternalFish.CheckRepeatedRow(NameCompany, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام شرکت تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ExternalFish.Insert(NameCompany, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string NameCompany, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


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
            else if (NameCompany == "" || NameCompany == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (NameCompany.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شرکت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameCompany.Length > 350)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شرکت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ExternalFish.CheckRepeatedRow(NameCompany, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ExternalFish.Update(Id, NameCompany, userId, Desc);

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

            return ExternalFish.Delete(id, userId);
        }
        #endregion
    }
}