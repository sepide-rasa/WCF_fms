using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_FishLog
    {
        DL_FishLog FishLog = new DL_FishLog();
        #region Detail
        public OBJ_FishLog Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return FishLog.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_FishLog> Select(string FieldName, string FilterValue, int h)
        {
            return FishLog.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(byte fldType, int? fldPersonalId, int fldOrganId, short fldYear, byte fldMonth, byte fldNobatPardakht, byte? fldFilterType, byte? fldFishType, int? fldCostCenterId, int? fldMahaleKhedmat, byte fldCalcType, byte? fldMostamar, string fldIP, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
           
            return FishLog.Insert(  fldType,  fldPersonalId,  fldOrganId,  fldYear,  fldMonth,  fldNobatPardakht,  fldFilterType,  fldFishType,  fldCostCenterId,  fldMahaleKhedmat,  fldCalcType,  fldMostamar,  fldIP,  UserId);
        }
        #endregion
    }
}