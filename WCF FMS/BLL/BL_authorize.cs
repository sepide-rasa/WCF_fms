using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL;

namespace WCF_FMS.BLL
{
    public class BL_authorize
    {
        public string ExistUser(string Username, string Password, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Username == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام کاربر ضروری است";
                return "خطا";
            }
            if (Password == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "رمز عبور ضروری است";
                return "خطا";
            }
            var userId = authorize.ExistUser(Username, Password);
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
            var Active = authorize.CheckActiveUser(Username, Password);
            if (Active==false)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                return "خطا";
            }
            return userId.ToString();
        }
    }
}