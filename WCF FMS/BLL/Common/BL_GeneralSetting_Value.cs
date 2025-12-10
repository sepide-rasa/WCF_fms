using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_GeneralSetting_Value
    {
        DL_GeneralSetting_Value GeneralSetting = new DL_GeneralSetting_Value();

        #region Detail
        public OBJ_GeneralSetting_Value Detail(int Id, int OrganId, out ClsError Error)
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
        public List<OBJ_GeneralSetting_Value> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return GeneralSetting.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(byte fldGeneralSettingId, string fldValue, int UserId, int fldOrganId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldGeneralSettingId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد تنظیمات عمومی ضروری است";
            }
            else if (fldOrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
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
            return GeneralSetting.Insert(fldGeneralSettingId, fldValue, UserId, fldOrganId, Desc);
        }
        #endregion
        #region Update
        public string Update(byte Id, byte fldGeneralSettingId, string fldValue, int UserId, int fldOrganId, string Desc, out ClsError Error)
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
            else if (fldGeneralSettingId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد تنظیمات عمومی ضروری است";
            }
            else if (fldOrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
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
            return GeneralSetting.Update(Id, fldGeneralSettingId, fldValue, UserId, fldOrganId, Desc);
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
    }
}