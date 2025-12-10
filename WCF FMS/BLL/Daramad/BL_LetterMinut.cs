using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_LetterMinut
    {
        DL_LetterMinut LetterMinut = new DL_LetterMinut();

        #region Detail
        public OBJ_LetterMinut Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LetterMinut.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_LetterMinut> Select(string FieldName, string FilterValue, int h)
        {
            return LetterMinut.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(int ShomareHesabCodeDaramadId, string Title, string DescMinut, bool SodoorBadAzVarizNaghdi, bool SodoorBadAzTaghsit, bool Tanzimkonande, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان الگو ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان الگو وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 400)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان الگو وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DescMinut == "" || DescMinut == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن الگو ضروری است";
            }
            else if (DescMinut.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر متن الگو وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return LetterMinut.Insert(ShomareHesabCodeDaramadId, Title, DescMinut, SodoorBadAzVarizNaghdi, SodoorBadAzTaghsit, Tanzimkonande, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabCodeDaramadId, string Title, string DescMinut, bool SodoorBadAzVarizNaghdi, bool SodoorBadAzTaghsit, bool Tanzimkonande, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان الگو ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان الگو وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 400)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان الگو وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DescMinut == "" || DescMinut == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن الگو ضروری است";
            }
            else if (DescMinut.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر متن الگو وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterMinut.Update(Id, ShomareHesabCodeDaramadId, Title, DescMinut, SodoorBadAzVarizNaghdi, SodoorBadAzTaghsit, Tanzimkonande, userId, Desc);

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
            else if (LetterMinut.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterMinut.Delete(id, userId);
        }
        #endregion
    }
}