using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_GeneralSetting
    {
        DL_GeneralSetting GeneralSetting = new DL_GeneralSetting();

        #region Detail
        public OBJ_GeneralSetting Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گروه کاربری ضروری است";
            }
            return GeneralSetting.Detail(Id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_GeneralSetting> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return GeneralSetting.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(string fldName, string fldValue, int fldOrganId,int fldModuleId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ماژول است";
            }
            else if (fldName == null || fldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldValue == null || fldValue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return 0;
            return GeneralSetting.Insert(fldName, fldValue, fldOrganId, fldModuleId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(byte Id, string fldName, string fldValue, int fldOrganId, int fldModuleId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (fldModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ماژول است";
            }
            else if (fldName == null || fldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldValue == null || fldValue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return GeneralSetting.Update(Id, fldName, fldValue, fldOrganId, fldModuleId, UserId, Desc);
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

            return GeneralSetting.Delete(Id, UserId);
        }
        #endregion

        #region GeneralSettingInsert
        public string GeneralSettingInsert(string fldName, string fldValue, int fldOrganId, int fldModuleId, System.Data.DataTable ComboBox, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ماژول است";
            }
            else if (fldName == null || fldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldValue == null || fldValue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return GeneralSetting.GeneralSettingInsert(fldName, fldValue, fldOrganId, fldModuleId,ComboBox, UserId, Desc);
        }
        #endregion
        #region GeneralSettingUpdate
        public string GeneralSettingUpdate(int fldHeaderId, string fldName, string fldValue, int fldOrganId, int fldModuleId, System.Data.DataTable ComboBox, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ماژول است";
            }
            else if (fldName == null || fldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldValue == null || fldValue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return GeneralSetting.GeneralSettingUpdate(fldHeaderId,fldName, fldValue, fldOrganId, fldModuleId, ComboBox, UserId, Desc);
        }
        #endregion
        #region GeneralSettingDelete
        public string GeneralSettingDelete(int Id, int UserId, out ClsError Error)
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

            return GeneralSetting.GeneralSettingDelete(Id, UserId);
        }
        #endregion
    }
}