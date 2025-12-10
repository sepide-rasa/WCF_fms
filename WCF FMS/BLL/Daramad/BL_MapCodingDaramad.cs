using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_MapCodingDaramad
    {
        DL_MapCodingDaramad MapCoding = new DL_MapCodingDaramad();
        #region MapCodingDaramad
        public string Map(string oldCode, string newCode, string title, int UserId, string pcode, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
           
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (oldCode == "" || oldCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد قدیم ضروری است";
            }
            else if (newCode == "" || newCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جدید ضروری است";
            }
            else if (pcode == "" || pcode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پدر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MapCoding.Map(oldCode, newCode, title, UserId, pcode);

        }
        #endregion
    }
}