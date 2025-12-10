using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_LoginFailed
    {
        DL_LoginFailed LoginFailed = new DL_LoginFailed();
        #region Insert
        public string Insert(string UserName,  string IP, out ClsError Error)
        {
            Error = new ClsError();
           
            if (Error.ErrorType == true)
                return "خطا";
            return LoginFailed.Insert(UserName, IP);
        }
        #endregion
    }
}