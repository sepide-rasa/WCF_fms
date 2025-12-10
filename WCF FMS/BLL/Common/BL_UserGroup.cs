using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_UserGroup
    {
        DL_UserGroup UserGroup = new DL_UserGroup();

        #region Detail
        public OBJ_UserGroup Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گروه کاربری ضروری است";
            }
            return UserGroup.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_UserGroup> Select(string FieldName, string FilterValue,int UserId, int h)
        {
            return UserGroup.Select(FieldName, FilterValue,UserId, h);
        }
        #endregion
        #region Insert
        public int Insert(string Title, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان گروه کاربری ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (UserGroup.CheckRepeatedRow(Title, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return 0;
            return UserGroup.Insert(Title, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int UserId, string Desc, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه گروه کاربری ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان گروه کاربری ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (UserGroup.CheckRepeatedRow(Title, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return UserGroup.Update(Id, Title, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId,string IP, out ClsError Error)
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
                Error.ErrorMsg = "کد گروه کاربری ضروری است";
            }
            else if (UserGroup.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "برای ماژول های انتخاب شده در گروه کاربری مورد نظر سطوح دسترسی تعریف شده لذا امکان حذف وجود ندارد.";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return UserGroup.Delete(Id, UserId);
        }
        #endregion
    }
}