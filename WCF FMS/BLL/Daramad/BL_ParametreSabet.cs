using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ParametreSabet
    {
        DL_ParametreSabet ParametreSabet = new DL_ParametreSabet();

        #region Detail
        public OBJ_ParametreSabet Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ParametreSabet.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ParametreSabet> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            return ParametreSabet.Select(FieldName, FilterValue, FilterValue1, h);
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesabCodeDaramadId, string NameParametreFa, string NameParametreEn, bool Noe, byte NoeField, bool Vaziyat, Nullable<int> ComboBaxId, bool TypeParametr, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (NameParametreFa == "" || NameParametreFa == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فارسی ضروری است";
            }
            else if (NameParametreFa.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreFa.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده بیشتر از حد مجاز می باشد. ";
            }
            else if (NameParametreEn == "" || NameParametreEn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام در فرمول ضروری است";
            }
            else if (NameParametreEn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreEn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارده شده بیشتر از حد مجاز می باشد. ";
            }
            else if (NoeField == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع فیلد ضروری است";
            }
            else if (NoeField > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع فیلد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ParametreSabet.CheckRepeatedRow(ShomareHesabCodeDaramadId, NameParametreFa, NameParametreEn, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet.Insert(ShomareHesabCodeDaramadId, NameParametreFa, NameParametreEn, Noe, NoeField, Vaziyat, ComboBaxId, TypeParametr, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabCodeDaramadId, string NameParametreFa, string NameParametreEn, bool Noe, byte NoeField, bool Vaziyat, Nullable<int> ComboBaxId,bool TypeParametr, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (NameParametreFa == "" || NameParametreFa == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فارسی ضروری است";
            }
            else if (NameParametreFa.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreFa.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده بیشتر از حد مجاز می باشد. ";
            }
            else if (NameParametreEn == "" || NameParametreEn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام در فرمول ضروری است";
            }
            else if (NameParametreEn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameParametreEn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام در فرمول وارده شده بیشتر از حد مجاز می باشد. ";
            }
            else if (NoeField == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع فیلد ضروری است";
            }
            else if (NoeField > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع فیلد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ParametreSabet.CheckRepeatedRow(ShomareHesabCodeDaramadId, NameParametreFa, NameParametreEn, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet.Update(Id, ShomareHesabCodeDaramadId, NameParametreFa, NameParametreEn, Noe, NoeField, Vaziyat, ComboBaxId, TypeParametr, userId, Desc);

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
            else if (ParametreSabet.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet.Delete(id, userId);
        }
        #endregion
    }
}