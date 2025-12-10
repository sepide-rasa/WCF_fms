using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_Tozin
    {
        DL_Tozin Tozin = new DL_Tozin();

        #region Select
        public List<OBJ_Tozin> Select(string FieldName, string FilterValue, string FilterValue2, string AzTarikh, string TaTarikh, int h)
        {
            return Tozin.Select(FieldName, FilterValue, FilterValue2, AzTarikh, TaTarikh, h);
        }
        #endregion

        #region Insert
        public string Insert(int fldWeighbridgeId, int fldMaxW, int? fldPlaqueId, DateTime fldHour, DateTime fldStartDate, DateTime fldEndDate, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (fldWeighbridgeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد باسکول ضروری است";
            }
            else if (fldMaxW == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وزن ضروری است";
            }
            else if (fldPlaqueId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پلاک ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Tozin.Insert(fldWeighbridgeId, fldMaxW, fldPlaqueId, fldHour, fldStartDate, fldEndDate);

        }
        #endregion
    }
}