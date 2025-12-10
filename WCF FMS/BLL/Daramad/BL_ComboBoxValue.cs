using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ComboBoxValue
    {
        DL_ComboBoxValue ComboBoxValue = new DL_ComboBoxValue();

        #region Detail
        public OBJ_ComboBoxValue Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ComboBoxValue.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ComboBoxValue> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            return ComboBoxValue.Select(FieldName, FilterValue,FilterValue1, h);
        }
        #endregion
        #region Insert
        public string Insert(int ComboBoxId, string Title, string Value, int userId, string Desc, out ClsError error)
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
            else if (Title.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Value == "" || Value == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (Value.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مقدار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ComboBoxValue.CheckRepeatedRow(ComboBoxId, Title, Value, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ComboBoxValue.Insert(ComboBoxId, Title, Value, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ComboBoxId, string Title, string Value, int userId, string Desc, out ClsError error)
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
            else if (Title.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Value == "" || Value == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (Value.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مقدار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ComboBoxValue.CheckRepeatedRow(ComboBoxId, Title, Value, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ComboBoxValue.Update(Id, ComboBoxId, Title, Value, userId, Desc);

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

            return ComboBoxValue.Delete(id, userId);
        }
        #endregion
    }
}