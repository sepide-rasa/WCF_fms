using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ParameteriItemsFormul
    {
        DL_ParameteriItemsFormul ParameteriItemsFormul = new DL_ParameteriItemsFormul();
        #region Detail
        public OBJ_ParameteriItemsFormul Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return ParameteriItemsFormul.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_ParameteriItemsFormul> Select(string FieldName, string FilterValue, int h)
        {
            return ParameteriItemsFormul.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ParametrId, string Formul, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ParametrId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پارامترها ضروری است";
            }
            else if (Formul == null || Formul=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمول ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return ParameteriItemsFormul.Insert(ParametrId, Formul, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int ParametrId, string Formul, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (ParametrId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پارامترها ضروری است";
            }
            else if (Formul == null || Formul == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمول ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return ParameteriItemsFormul.Update(Id, ParametrId, Formul, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return ParameteriItemsFormul.Delete(Id, UserId);
        }
        #endregion
    }
}