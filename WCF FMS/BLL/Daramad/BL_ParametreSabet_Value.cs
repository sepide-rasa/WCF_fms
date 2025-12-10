using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ParametreSabet_Value
    {
        DL_ParametreSabet_Value ParametreSabet_Value = new DL_ParametreSabet_Value();

        #region Detail
        public OBJ_ParametreSabet_Value Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ParametreSabet_Value.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ParametreSabet_Value> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            return ParametreSabet_Value.Select(FieldName, FilterValue, FilterValue1, h);
        }
        #endregion
        #region Insert
        public string Insert(int ElamAvarezId, string Value, int ParametrSabetId, int? CodeDaramadElamAvarezId, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (ParametrSabetId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامترهای ثابت ضروری است";
            }
            else if (Value == "" || Value==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (Value.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مقدار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ParametreSabet_Value.CheckRepeatedRow(CodeDaramadElamAvarezId, ParametrSabetId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار پارامتر مورد نظر قبلا ثبت شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet_Value.Insert(ElamAvarezId, Value, ParametrSabetId, CodeDaramadElamAvarezId, UserId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, string Value, int ParametrSabetId, int? CodeDaramadElamAvarezId, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
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
            else if (ParametrSabetId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامترهای ثابت ضروری است";
            }
            else if (Value == "" || Value == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (Value.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مقدار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ParametreSabet_Value.CheckRepeatedRow(CodeDaramadElamAvarezId, ParametrSabetId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار پارامتر مورد نظر قبلا ثبت شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet_Value.Update(Id, ElamAvarezId, Value, ParametrSabetId,CodeDaramadElamAvarezId, UserId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(int ElamAvarezId, int ShomareHesabCodeDaramadId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            /*else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }*/
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet_Value.Delete(ElamAvarezId, ShomareHesabCodeDaramadId, userId);
        }
        #endregion
    }
}