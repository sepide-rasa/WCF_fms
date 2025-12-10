using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;
namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MaliyatDaraei
    {
        DL_MaliyatDaraei MaliyatDaraei = new DL_MaliyatDaraei();
        #region Update
        public string Update(short fldYear, byte fldMonth, byte fldNobatePardakht, int fldOrganId, int fldUserId, string fldIp, out ClsError Error)
        {
            Error = new ClsError();
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldYear == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (fldMonth == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (fldNobatePardakht == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوبت پرداخت ضروری است";
            }

            return MaliyatDaraei.Update(fldYear, fldMonth, fldNobatePardakht, fldOrganId, fldUserId, fldIp);
        }
        #endregion
        #region Delete
        public string Delete(short fldYear, byte fldMonth, byte fldNobatePardakht, int fldOrganId, int fldUserId, string fldIp, out ClsError Error)
        {
            Error = new ClsError();
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldYear == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (fldMonth == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (fldNobatePardakht == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوبت پرداخت ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return MaliyatDaraei.Delete(fldYear, fldMonth, fldNobatePardakht, fldOrganId, fldUserId, fldIp);
        }
        #endregion
    }
}