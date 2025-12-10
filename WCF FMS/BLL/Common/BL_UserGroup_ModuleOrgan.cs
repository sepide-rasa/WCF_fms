using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_UserGroup_ModuleOrgan
    {
        DL_UserGroup_ModuleOrgan UserGroup_ModuleOrgan = new DL_UserGroup_ModuleOrgan();

        #region Detail
        public OBJ_UserGroup_ModuleOrgan Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return UserGroup_ModuleOrgan.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_UserGroup_ModuleOrgan> Select(string FieldName, string FilterValue, int h)
        {
            return UserGroup_ModuleOrgan.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int UserGroupId, int ModuleOrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (UserGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه کاربری ضروری است";
            }
            else if (ModuleOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماژول-سازمان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return UserGroup_ModuleOrgan.Insert(UserGroupId, ModuleOrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int UserGroupId, int ModuleOrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

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
            else if (UserGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه کاربری ضروری است";
            }
            else if (ModuleOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماژول-سازمان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return UserGroup_ModuleOrgan.Update(Id, UserGroupId, ModuleOrganId, userId, Desc);

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

            return UserGroup_ModuleOrgan.Delete(id, userId);
        }
        #endregion
    }
}