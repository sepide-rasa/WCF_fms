using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_RequestTaghsit_Takhfif
    {
        DL_RequestTaghsit_Takhfif RequestTaghsit_Takhfif = new DL_RequestTaghsit_Takhfif();

        #region Detail
        public OBJ_RequestTaghsit_Takhfif Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return RequestTaghsit_Takhfif.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_RequestTaghsit_Takhfif> Select(string FieldName, string FilterValue, int h)
        {
            return RequestTaghsit_Takhfif.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(int ElamAvarezId, byte RequestType, int EmployeeId, string Address, string Email, string CodePosti, string Mobile, int userId, string Desc, out ClsError error)
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
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (EmployeeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارمند ضروری است";
            }
            else if (Mobile == "" || Mobile == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره موبایل ضروری است";
            }
            else if (Mobile.Length < 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره موبایل وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Mobile.Length > 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره موبایل وارد شده بزرگتر از 11 رقم می باشد";
            }
            else if (RequestType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع درخواست وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Address != null)
            {
                if (Address.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
                }
            }
            if (Email != null)
            {
                if (Email.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر پست الکترونیک وارد شده کمتر از حد مجاز میباشد.";
                }
                if (Email.Length > 150)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر پست الکترونیک وارده شده بیشتر از حد مجاز می باشد.";
                }
            }

            if (CodePosti != null)
            {
                if (CodePosti.Length < 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر کد پستی وارد شده کمتر از حد مجاز میباشد.";
                }
                if (CodePosti.Length > 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد پستی وارد شده بزرگتر از 10 رقم می باشد";
                }
            }
            
            if (error.ErrorType == true)
                return 0;

            return RequestTaghsit_Takhfif.Insert(ElamAvarezId, RequestType, EmployeeId, Address, Email, CodePosti, Mobile, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, byte RequestType, int EmployeeId, string Address, string Email, string CodePosti, string Mobile, int userId, string Desc, out ClsError error)
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
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (EmployeeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارمند ضروری است";
            }
            else if (Mobile == "" || Mobile == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره موبایل ضروری است";
            }
            else if (Mobile.Length < 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره موبایل وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Mobile.Length > 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره موبایل وارد شده بزرگتر از 11 رقم می باشد";
            }
            else if (RequestType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع درخواست وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Address != null)
            {
                if (Address.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
                }
            }
            if (Email != null)
            {
                if (Email.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر پست الکترونیک وارد شده کمتر از حد مجاز میباشد.";
                }
                if (Email.Length > 150)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر پست الکترونیک وارده شده بیشتر از حد مجاز می باشد.";
                }
            }

            if (CodePosti != null)
            {
                if (CodePosti.Length < 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر کد پستی وارد شده کمتر از حد مجاز میباشد.";
                }
                if (CodePosti.Length > 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد پستی وارد شده بزرگتر از 10 رقم می باشد";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return RequestTaghsit_Takhfif.Update(Id, ElamAvarezId, RequestType, EmployeeId, Address, Email, CodePosti, Mobile, userId, Desc);

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
            else if (RequestTaghsit_Takhfif.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return RequestTaghsit_Takhfif.Delete(id, userId);
        }
        #endregion
    }
}