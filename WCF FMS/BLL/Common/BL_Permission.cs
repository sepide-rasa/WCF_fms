using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Permission
    {
        DL_Permission Permission = new DL_Permission();
        #region Select
        public List<OBJ_Permission> Select(string FieldName, string FilterValue, int UserId, int OrganId, int h, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            if (Error.ErrorType == true)
            {
                return null;
            }
            return Permission.Select(FieldName, FilterValue, UserId, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldUserGroup_ModuleOrganID, int ApplicationPartId, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است.";
            }
            else if (fldUserGroup_ModuleOrganID == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد گروه کاربری ماژول-سازمان ضروری است.";
            }
            else if (ApplicationPartId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد گره ضروری است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Permission.Insert(fldUserGroup_ModuleOrganID, ApplicationPartId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int UserGroupId, int ModuleId, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (UserGroupId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گروه کاربری ضروری است.";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return Permission.Delete(UserGroupId, ModuleId, UserId);
        }
        #endregion
        #region CopyPermission
        public string CopyPermission(int por, int khali, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است.";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return Permission.CopyPermission(por, khali, UserId);
        }
        #endregion
        #region DeleteChildUserGroupPermission
        public string DeleteChildUserGroupPermission(int UserGroup_ModuleOrganId, string appId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserGroup_ModuleOrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است.";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return Permission.DeleteChildUserGroupPermission(UserGroup_ModuleOrganId, appId);
        }
        #endregion
    }
}