using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Archive;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.BLL.Archive
{
    public class BL_Properties
    {
        DL_Properties Properties = new DL_Properties();

        #region Detail
        public OBJ_Properties Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Properties.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Properties> Select(string FieldName, string FilterValue, int h)
        {
            return Properties.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string NameFn, string NameEn, int Type, int? FormulId, int userId, string Desc, out ClsError error)
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
            else if (NameFn == "" || NameFn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان فارسی ضروری است";
            }
            else if (NameFn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameFn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NameEn == "" || NameEn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان انگلیسی ضروری است";
            }
            else if (NameEn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameEn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Properties.CheckRepeatedRow(NameFn, NameEn, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Properties.Insert(NameFn, NameEn, Type, FormulId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string NameFn, string NameEn, int Type, int? FormulId, int userId, string Desc, out ClsError error)
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
            else if (NameFn == "" || NameFn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان فارسی ضروری است";
            }
            else if (NameFn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameFn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NameEn == "" || NameEn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان انگلیسی ضروری است";
            }
            else if (NameEn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameEn.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Properties.CheckRepeatedRow(NameFn, NameEn, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Properties.Update(Id, NameFn, NameEn, Type, FormulId, userId, Desc);

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
            else if (Properties.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Properties.Delete(id, userId);
        }
        #endregion
    }
}