using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ShomareHesabPasAndaz
    {
        DL_ShomareHesabPasAndaz ShomareHesabPasAndaz = new DL_ShomareHesabPasAndaz();
        #region Detail
        public OBJ_ShomareHesabPasAndaz Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return ShomareHesabPasAndaz.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabPasAndaz> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return ShomareHesabPasAndaz.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ShomareHesabPersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب پرسنل ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return ShomareHesabPasAndaz.Insert(ShomareHesabPersonalId, ShomareHesabKarfarmaId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, int UserId, string Desc, out ClsError Error)
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
            else if (ShomareHesabPersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب پرسنل ضروری است";
            }
            else if (ShomareHesabKarfarmaId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب کارفرما ضروری است";
            }
           
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return ShomareHesabPasAndaz.Update(Id, ShomareHesabPersonalId, ShomareHesabKarfarmaId, UserId, Desc);
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
            return ShomareHesabPasAndaz.Delete(Id, UserId);
        }
        #endregion
    }
}