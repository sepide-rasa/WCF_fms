using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Psp
    {
        DL_Psp Psp = new DL_Psp();

        #region Detail
        public OBJ_Psp Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Psp.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Psp> Select(string FieldName, string FilterValue, int h)
        {
            return Psp.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title,byte[] File, string Pasvand, int userId, string Desc, out ClsError error)
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
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Psp.CheckRepeatedRow(Title, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Psp.Insert(Title, File, Pasvand, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int FileId, byte[] File, string Pasvand, int userId, string Desc, out ClsError error)
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
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FileId ==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فایل ضروری است.";
            }
            else if (Psp.CheckRepeatedRow(Title, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است.";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Psp.Update(Id, Title, FileId, File, Pasvand, userId, Desc);

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
            else if (Psp.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Psp.Delete(id, userId);
        }
        #endregion
    }
}