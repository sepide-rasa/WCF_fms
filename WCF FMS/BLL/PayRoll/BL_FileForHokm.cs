using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_FileForHokm
    {
        DL_FileForHokm FileForHokm = new DL_FileForHokm();
        #region Insert
        public string Insert(int fldPersonalHokmId, byte[] fldImage, string fldPasvand, int fldUserId, string fldDesc, out ClsError Error)
        {
            Error = new ClsError();
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (fldPersonalHokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم پرسنلی ضروری است";
            }
            /*else if (GHarardadBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد قرارداد بیمه ضروری است";
            }*/
            if (fldDesc == null)
                fldDesc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return FileForHokm.Insert(fldPersonalHokmId, fldImage, fldPasvand, fldUserId, fldDesc);
        }
        #endregion
    }
}