using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterNumber
    {
        DL_LetterNumber LetterNumber = new DL_LetterNumber();

        
        #region Insert
        public int Insert(long fldLetterId, int StartNumber, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldLetterId ==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
           
            if (error.ErrorType == true)
                return 0;

            return LetterNumber.Insert(fldLetterId, StartNumber, OrganID, UserId, Desc, IP);

        }
        #endregion
    }
}