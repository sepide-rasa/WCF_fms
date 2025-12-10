using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_UpdateStatusSanad
    {
        DL_UpdateStatusSanad StatusSanad = new DL_UpdateStatusSanad();
        #region Update
        public string Update(byte Type, int Id, byte Status, string DateStatus, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Type==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع سند ضروری است";
            }
            else if (Status == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت ضروری است";
            }
            else if (DateStatus == "" || DateStatus == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ تغییر وضعیت ضروری است";
            }
            else if (!r.IsMatch(DateStatus))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return StatusSanad.Update(Type, Id, Status,DateStatus, UserId);

        }
        #endregion
    }
}