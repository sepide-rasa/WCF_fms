using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ParametreSabet_Nerkh
    {
        DL_ParametreSabet_Nerkh ParametreSabet_Nerkh = new DL_ParametreSabet_Nerkh();

        #region Detail
        public OBJ_ParametreSabet_Nerkh Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ParametreSabet_Nerkh.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ParametreSabet_Nerkh> Select(string FieldName, string FilterValue, int h)
        {
            return ParametreSabet_Nerkh.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ParametreSabetId, string TarikhFaalSazi, string Value, int userId, string Desc, out ClsError error)
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
            else if (ParametreSabetId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامتر ثابت ضروری است";
            }
            else if (TarikhFaalSazi == null || TarikhFaalSazi=="")
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ فعال سازی ضروری است.";
            }
            else if (!r.IsMatch(TarikhFaalSazi))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet_Nerkh.Insert(ParametreSabetId, TarikhFaalSazi, Value, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ParametreSabetId, string TarikhFaalSazi, string Value, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

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
            else if (ParametreSabetId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامتر ثابت ضروری است";
            }
            else if (TarikhFaalSazi == null || TarikhFaalSazi == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ فعال سازی ضروری است.";
            }
            else if (!r.IsMatch(TarikhFaalSazi))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametreSabet_Nerkh.Update(Id, ParametreSabetId, TarikhFaalSazi, Value, userId, Desc);

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

            return ParametreSabet_Nerkh.Delete(id, userId);
        }
        #endregion
    }
}