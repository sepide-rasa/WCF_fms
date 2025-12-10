using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_TypeEstekhdam_UserGroup
    {
        DL_TypeEstekhdam_UserGroup TypeEstekhdam_UserGroup = new DL_TypeEstekhdam_UserGroup();
        #region Detail
        public OBJ_TypeEstekhdam_UserGroup Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return TypeEstekhdam_UserGroup.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_TypeEstekhdam_UserGroup> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return TypeEstekhdam_UserGroup.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTypeEstekhamId, int fldUseGroupId, int OrganId, int UserId, string Desc,string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (fldTypeEstekhamId == ""||fldTypeEstekhamId ==null )
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع استخدام ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldUseGroupId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد گروه کاربری ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return TypeEstekhdam_UserGroup.Insert(fldTypeEstekhamId, fldUseGroupId, OrganId, UserId, Desc, IP);
        }
        #endregion
        #region Update
        public string Update(int Id, string fldTypeEstekhamId, int fldUseGroupId, int OrganId, int UserId, string Desc, string IP, out ClsError Error)
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
            else if (fldTypeEstekhamId == "" || fldTypeEstekhamId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع استخدام ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldUseGroupId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد گروه کاربری ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return TypeEstekhdam_UserGroup.Update(Id, fldTypeEstekhamId, fldUseGroupId, OrganId, UserId, Desc, IP);
        }
        #endregion
        #region Delete
        public string Delete(int UserGroupId, int UserId, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (UserGroupId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return TypeEstekhdam_UserGroup.Delete(UserGroupId, UserId, OrganId);
        }
        #endregion
    }
}