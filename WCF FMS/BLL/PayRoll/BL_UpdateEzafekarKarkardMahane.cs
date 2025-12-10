using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_UpdateEzafekarKarkardMahane
    {
        DL_UpdateEzafekarKarkardMahane UpdateEzafekarKarkardMahane = new DL_UpdateEzafekarKarkardMahane();
        #region Update
        public string Update(decimal ezafekar, bool ghati, int personalId, byte mah, short year, out ClsError Error)
        {
            Error = new ClsError();
            if (personalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (mah == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return UpdateEzafekarKarkardMahane.Update(ezafekar, ghati, personalId, mah, year);
        }
        #endregion
    }
}