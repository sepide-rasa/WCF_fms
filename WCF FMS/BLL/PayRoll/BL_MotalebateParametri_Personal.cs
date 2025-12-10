using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MotalebateParametri_Personal
    {
        DL_MotalebateParametri_Personal MotalebateParametri_Personal = new DL_MotalebateParametri_Personal();
        #region Detail
        public OBJ_MotalebateParametri_Personal Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MotalebateParametri_Personal.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_MotalebateParametri_Personal> Select(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int OrganId, int h)
        {
            return MotalebateParametri_Personal.Select(FieldName, FilterValue, FilterValue1, FilterValue2, FilterValue3, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (ParametrId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پارامترها ضروری است";
            }
            else if (TarikhPardakht == null || TarikhPardakht == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (!r.IsMatch(TarikhPardakht))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MotalebateParametri_Personal.Insert(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime,  fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc);
        }
        #endregion
        #region InsertGroup
        public string InsertGroup(string PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PersonalId == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (ParametrId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پارامترها ضروری است";
            }
            else if (TarikhPardakht == null || TarikhPardakht == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (!r.IsMatch(TarikhPardakht))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MotalebateParametri_Personal.InsertGroup(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime, fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (ParametrId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پارامترها ضروری است";
            }
            else if (TarikhPardakht == null || TarikhPardakht == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (!r.IsMatch(TarikhPardakht))
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
            return MotalebateParametri_Personal.Update(Id, PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime,  fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc);
        }
        #endregion
        #region UpdateDeactive
        public string UpdateDeactive(string PersonalId, int ParametrId, int Mablagh, string TarikhePardakht,
             bool Status, int DateDeactive, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Mablagh == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مبلغ ضروری است";
            }
            else if (DateDeactive == 0 && Status == false)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ غیرفعالی ضروری است";
            }
            else if (PersonalId == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (ParametrId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پارامترها ضروری است";
            }
            else if (ParametrId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پارامترها ضروری است";
            }
            else if (TarikhePardakht == null || TarikhePardakht == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (!r.IsMatch(TarikhePardakht))
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
            return MotalebateParametri_Personal.UpdateDeactive(PersonalId, ParametrId, Mablagh, TarikhePardakht, Status, DateDeactive, UserId, Desc);
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
            else if (MotalebateParametri_Personal.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return MotalebateParametri_Personal.Delete(Id, UserId);
        }
        #endregion
    }
}