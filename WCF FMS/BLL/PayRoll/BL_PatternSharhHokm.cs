using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_PatternSharhHokm
    {
        DL_PatternSharhHokm PatternSharhHokm = new DL_PatternSharhHokm();

        #region Detail
        public OBJ_PatternSharhHokm Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PatternSharhHokm.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PatternSharhHokm> Select(string FieldName, string FilterValue, int h)
        {
            return PatternSharhHokm.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string PatternText, string HokmType, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (HokmType == null || HokmType == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع حکم ضروری است";
            }
            else if (PatternText == null || PatternText == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن الگو ضروری است";
            }
            else if (HokmType.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع حکم وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (HokmType.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع حکم وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternSharhHokm.Insert(PatternText, HokmType, UserId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string PatternText, string HokmType, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (HokmType == null || HokmType == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع حکم ضروری است";
            }
            else if (PatternText == null || PatternText == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن الگو ضروری است";
            }
            else if (HokmType.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع حکم وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (HokmType.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع حکم وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternSharhHokm.Update(Id, PatternText, HokmType, UserId, Desc);

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
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternSharhHokm.Delete(id, userId);
        }
        #endregion
    }
}