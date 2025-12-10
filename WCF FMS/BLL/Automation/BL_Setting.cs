using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Setting
    {
        DL_Setting Setting = new DL_Setting();

        #region Detail
        public OBJ_Setting Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Setting.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Setting> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Setting.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string EmailAddress, string EmailPassword, string RecieveServer, string SendServer, int SendPort, bool SSL, bool DelFax, bool IsSigner, string FaxPath, int RecievePort, int OrganID, int UserID, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (EmailAddress.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (EmailPassword.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر رمز عبور ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (RecieveServer.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر سرور دریافت ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (SendServer.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر سرور ارسال ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FaxPath.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مسیر دریافت وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Setting.Insert(EmailAddress, EmailPassword, RecieveServer, SendServer, SendPort, SSL, DelFax, IsSigner, FaxPath, RecievePort, OrganID, UserID, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string EmailAddress, string EmailPassword, string RecieveServer, string SendServer, int SendPort, bool SSL, bool DelFax, bool IsSigner, string FaxPath, int RecievePort, int OrganID, int UserID, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (EmailAddress.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (EmailPassword.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر رمز عبور ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (RecieveServer.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر سرور دریافت ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (SendServer.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر سرور ارسال ایمیل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FaxPath.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مسیر دریافت وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Setting.Update(Id, EmailAddress, EmailPassword, RecieveServer, SendServer, SendPort, SSL, DelFax, IsSigner, FaxPath, RecievePort, OrganID, UserID, Desc, IP);

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

            return Setting.Delete(id, userId);
        }
        #endregion
    }
}