using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_UpdateFlag
    {
        DL_UpdateFlag UpdateFlag = new DL_UpdateFlag();
        #region Update
        public string Update(string fieldName, short sal, byte mah, byte nobat, byte marhalePardaht, int OrganId, byte Type, int UserId, string Ip,byte fldCalcType, out ClsError Error)
        {
            Error = new ClsError();
            if (sal == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (mah == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }

            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return UpdateFlag.Update(fieldName, sal, mah, nobat, marhalePardaht, OrganId, Type, UserId, Ip, fldCalcType);
        }
        #endregion
    }
}