using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MandehPasAndaz
    {
        DL_MandehPasAndaz MandehPasAndaz = new DL_MandehPasAndaz();
        #region Detail
        public OBJ_MandehPasAndaz Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return MandehPasAndaz.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_MandehPasAndaz> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return MandehPasAndaz.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int Mablagh, string TarikhSabt, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (PersonalId==0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (TarikhSabt == null || TarikhSabt == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ثبت ضروری است";
            }
            else if (!r.IsMatch(TarikhSabt))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MandehPasAndaz.Insert(PersonalId, Mablagh, TarikhSabt, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int Mablagh, string TarikhSabt, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
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

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (TarikhSabt == null || TarikhSabt == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ثبت ضروری است";
            }
            else if (!r.IsMatch(TarikhSabt))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return MandehPasAndaz.Update(Id, PersonalId, Mablagh, TarikhSabt, UserId, Desc);
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
            return MandehPasAndaz.Delete(Id, UserId);
        }
        #endregion
    }
}