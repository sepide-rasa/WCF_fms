using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Module
    {
        DL_Module Module = new DL_Module();
        #region Detail
        public OBJ_Module Detail(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return Module.Detail(Id, UserId);
        }
        #endregion
        #region Select
        public List<OBJ_Module> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            return Module.Select(FieldName, FilterValue, UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, int UserId, string Desc, string IP, out ClsError Error)
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
                Error.ErrorMsg = "عنوان ماژول ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان ماژول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان ماژول وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Module.CheckRepeatedRow(Title, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ماژول تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Module.Insert(UserId,Title,Desc);
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
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ماژول ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان ماژول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان ماژول وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Module.CheckRepeatedRow(Title, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ماژول تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Module.Update(Id,UserId,Title, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (Module.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return Module.Delete(Id, UserId);
        }
        #endregion
    }
}