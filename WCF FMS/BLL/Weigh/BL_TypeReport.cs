using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_TypeReport
    {
        DL_TypeReport TypeReport = new DL_TypeReport();

        #region Select
        public List<OBJ_TypeReport> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return TypeReport.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(byte fldType, int fldOrganId, int fldBaskoolId, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (fldType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع گزارش ضروری است";
            }

            else if (fldOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارگان ضروری است";
            }
            else if (fldBaskoolId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد باسکول ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TypeReport.Insert(fldType, fldOrganId, fldBaskoolId, userId, IP);

        }
        #endregion
    }
}