using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ParametreOmoomi
    {
        DL_ParametreOmoomi ParametreOmoomi = new DL_ParametreOmoomi();

        #region Detail
        public OBJ_ParametreOmoomi Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ParametreOmoomi.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ParametreOmoomi> Select(string FieldName, string FilterValue, int h)
        {
            return ParametreOmoomi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string NameParametreFa, string NameParametreEn, byte NoeField, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (NameParametreFa == "" || NameParametreFa == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فارسی ضروری است.";
            }
            else if (NameParametreFa.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreFa.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NameParametreEn == "" || NameParametreEn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام در فرمول ضروری است.";
            }
            else if (NameParametreEn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreEn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NoeField == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع فیلد ضروری است.";
            }
            else if (NoeField > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع فیلد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ParametreOmoomi.CheckRepeatedRow(NameParametreEn, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام در فرمول وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreOmoomi.Insert(NameParametreFa, NameParametreEn, NoeField, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string NameParametreFa, string NameParametreEn, byte NoeField, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (NameParametreFa == "" || NameParametreFa == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فارسی ضروری است.";
            }
            else if (NameParametreFa.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreFa.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NameParametreEn == "" || NameParametreEn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام در فرمول ضروری است.";
            }
            else if (NameParametreEn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreEn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NoeField == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع فیلد ضروری است.";
            }
            else if (NoeField > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع فیلد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ParametreOmoomi.CheckRepeatedRow(NameParametreEn, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام در فرمول وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreOmoomi.Update(Id, NameParametreFa, NameParametreEn, NoeField, userId, Desc);

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
            else if (ParametreOmoomi.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreOmoomi.Delete(id, userId);
        }
        #endregion
    }
}