using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_User_Group
    {
        DL_User_Group User_Group = new DL_User_Group();

        #region Detail
        public OBJ_User_Group Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return User_Group.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_User_Group> Select(string FieldName, string FilterValue, int h)
        {
            return User_Group.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int UserGroupId, int UserSelectId, int UserId, bool fldGrant, bool fldWithGrant, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (UserSelectId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر جهت تعیین دسترسی ضروری است";
            }
            else if (UserGroupId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گروه کاربری ضروری است";
            }
            else if (User_Group.CheckRepeatedRow(UserSelectId,UserGroupId,0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return User_Group.Insert(UserGroupId, UserSelectId, UserId, fldGrant, fldWithGrant, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int UserGroupId, int UserSelectId, int UserId, bool fldGrant, bool fldWithGrant, string Desc, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (UserSelectId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر جهت تعیین دسترسی ضروری است";
            }
            else if (UserGroupId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گروه کاربری ضروری است";
            }
            else if (User_Group.CheckRepeatedRow(UserSelectId, UserGroupId,Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return User_Group.Update(Id, UserGroupId, UserSelectId, UserId,fldGrant,fldWithGrant, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId,string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return User_Group.Delete(Id, UserId);
        }
        #endregion
    }
}