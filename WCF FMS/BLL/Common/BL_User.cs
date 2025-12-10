using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_User
    {
        DL_User User = new DL_User();

        #region Detail
        public OBJ_User Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return User.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_User> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return User.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region Insert
        public int Insert(int EmployeeId, string UserName, string PassWord, bool Active_Deactive, int UserId, string Desc,string IP,out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (EmployeeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کارمند ضروری است";
            }
            else if (UserName == null||UserName=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری ضروری است";
            }
            else if (PassWord == null||PassWord=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "رمز عبور ضروری است";
            }
            else if (User.CheckRepeatedRow(UserName, EmployeeId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";     
            if (Error.ErrorType == true)
                return 0;

            return User.Insert(EmployeeId, UserName, PassWord, Active_Deactive, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id,int EmployeeId, string UserName, bool Active_Deactive, int UserId, string Desc, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه کاربر جهت ویرایش ضروری است";
            }
            else if (EmployeeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کارمند ضروری است";
            }
            else if (UserName == null || UserName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری ضروری است";
            }
            else if (User.CheckRepeatedRow(UserName, EmployeeId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return User.Update(Id, EmployeeId, UserName, Active_Deactive, UserId, Desc);
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
                Error.ErrorMsg = "شناسه کاربر جهت حذف ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return User.Delete(Id, UserId);
        }
        #endregion
        #region ResetPass
        public string ResetPass(int Id, string Password, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر جهت ریست رمز عبور ضروری است";
            }
            else if (Password == null||Password=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "رمز عبور ضروری است";
            }
            return User.ResetPass(Id, Password);
        }
        #endregion
        #region ChangePass
        public string ChangePass(int Id, string Pass, string UserName, string NewPass, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (UserName == null||UserName=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری ضروری است";
            }
            else if (Pass == null || Pass == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "رمز عبور قبلی ضروری است";
            }
            else if (NewPass == null||NewPass=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "رمز عبور جدید ضروری است";
            }
            var fldPassword = User.Select("fldId", Id.ToString(), "", 1).FirstOrDefault().fldPassword;
            if (Pass != fldPassword)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "رمز فعلی وارد شده معتبر نیست.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return User.ResetPass(Id, NewPass);
        }
        #endregion
        #region SelectUserByUserId
        public List<OBJ_User> SelectUserByUserId(string FieldName, string FilterValue, int UserId, int h)
        {
            return User.SelectUserByUserId(FieldName, FilterValue, UserId, h);
        }
        #endregion

        #region UpdateActiveUser
        public string UpdateActiveUser(int Id, bool Active_Deactive, out ClsError Error)
        {
            Error = new ClsError();
             if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر جهت غیرفعال کردن ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return User.UpdateActiveUser(Id,  Active_Deactive);
        }
        #endregion
    }
}