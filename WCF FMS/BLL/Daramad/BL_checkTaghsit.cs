using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_checkTaghsit
    {
        DL_CheckTaghsit CheckTaghsit = new DL_CheckTaghsit();
        #region CheckTaghsit
        public List<OBJ_CheckTaghsit> checkTaghsit(int ElamAvarezId)
        {
            return CheckTaghsit.checkTaghsit(ElamAvarezId);
        }
        #endregion
        #region Delete
        public string Delete(int ElamAvarezId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CheckTaghsit.Delete(ElamAvarezId, userId);
        }
        #endregion
    }
}