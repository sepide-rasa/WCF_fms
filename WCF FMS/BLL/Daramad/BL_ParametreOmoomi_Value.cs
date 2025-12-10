using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ParametreOmoomi_Value
    {
        DL_ParametreOmoomi_Value ParametreOmoomi_Value = new DL_ParametreOmoomi_Value();

        #region Detail
        public OBJ_ParametreOmoomi_Value Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ParametreOmoomi_Value.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ParametreOmoomi_Value> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            return ParametreOmoomi_Value.Select(FieldName, FilterValue, FilterValue1, h);
        }
        #endregion
        #region Insert
        public string Insert(int ParametreOmoomiId, string FromDate, string EndDate, string Value, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ParametreOmoomiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامتر عمومی ضروری است";
            }
            else if (FromDate == "" || FromDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
           
            else if (!r.IsMatch(FromDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Value.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مقدار وارده شده بیشتر از حد مجاز می باشد. ";
            }
            else if (Value == "" || Value == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
           else if (ParametreOmoomi_Value.CheckRepeatedRow(ParametreOmoomiId,FromDate, EndDate, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "در بازه انتخاب شده اطلاعات از پیش ثبت شده است.";
            }
            if (EndDate != null)
            {
                if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(FromDate)).TotalDays < 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
                }
                if (!r.IsMatch(EndDate))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreOmoomi_Value.Insert(ParametreOmoomiId, FromDate, EndDate, Value, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ParametreOmoomiId, string FromDate, string EndDate, string Value, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
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
            else if (ParametreOmoomiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامتر عمومی ضروری است";
            }
            else if (FromDate == "" || FromDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
            
            else if (!r.IsMatch(FromDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Value.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مقدار وارده شده بیشتر از حد مجاز می باشد. ";
            }
            else if (Value == "" || Value == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (ParametreOmoomi_Value.CheckRepeatedRow(ParametreOmoomiId, FromDate, EndDate, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "در بازه انتخاب شده اطلاعات از پیش ثبت شده است.";
            }
            if (EndDate != null)
            {
                if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(FromDate)).TotalDays < 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
                }
                if (!r.IsMatch(EndDate))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreOmoomi_Value.Update(Id, ParametreOmoomiId, FromDate, EndDate, Value, userId, Desc);

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

            return ParametreOmoomi_Value.Delete(id, userId);
        }
        #endregion
    }
}