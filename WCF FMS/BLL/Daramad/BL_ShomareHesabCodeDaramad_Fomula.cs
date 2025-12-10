using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;
using System.Text.RegularExpressions;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ShomareHesabCodeDaramad_Fomula
    {
        DAL_ShomareHesabCodeDaramad_Fomula DL_ShomareHesabCodeDaramad_Fomula = new DAL_ShomareHesabCodeDaramad_Fomula();

        #region Select
        public List<OBJ_ShomareHesabCodeDaramad_Fomula> Select(string FieldName, string FilterValue,int organid, int h)
        {
            return DL_ShomareHesabCodeDaramad_Fomula.Select(FieldName, FilterValue, organid, h);
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesab_CodeId, string Formul, string TarikhEjra, int UserId, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ShomareHesab_CodeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (Formul =="")
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمول ضروری است";
            }
            else if (TarikhEjra == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (!r.IsMatch(TarikhEjra))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DL_ShomareHesabCodeDaramad_Fomula.Insert(ShomareHesab_CodeId, Formul, TarikhEjra, UserId);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesab_CodeId, string Formul, string TarikhEjra, int UserId, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;

            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }            
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ShomareHesab_CodeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (Formul == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمول ضروری است";
            }
            else if (TarikhEjra == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (!r.IsMatch(TarikhEjra))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DL_ShomareHesabCodeDaramad_Fomula.Update(Id, ShomareHesab_CodeId, Formul, TarikhEjra, UserId);
        }
        #endregion
    }
}