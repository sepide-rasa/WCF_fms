using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_CheckEmail
    {
        DL_CheckEmail EmailCheck = new DL_CheckEmail();
        #region CheckEmail
        public OBJ_CheckEmail CheckEmail(string Email, out ClsError error)
        {
            error = new ClsError();
            if (Email == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "ایمیل ضروری است";
            }
            return EmailCheck.CheckEmail(Email);
        }
        #endregion
    }
}