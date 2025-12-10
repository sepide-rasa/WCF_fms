using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_RptCodingStatus
    {
        DL_RptCodingStatus CodingStatus = new DL_RptCodingStatus();

        #region RptCodingStatus
        public List<OBJ_RptCodingStatus> RptCodingStatus(int CodingDetailId, byte flag, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId,byte Type, out ClsError error)
        {
            error = new ClsError();
            return CodingStatus.RptCodingStatus(CodingDetailId, flag, CaseTypeId, SourceId, Year, OrganId, moduleSaveId, Type);
        }
        #endregion
        #region RptCodingStatus_Parvande
        public List<OBJ_RptCodingStatus> RptCodingStatus_Parvande(int CodingDetailId, byte flag, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId, byte Type, out ClsError error)
        {
            error = new ClsError();
            return CodingStatus.RptCodingStatus_Parvande(CodingDetailId, flag, CaseTypeId, SourceId, Year, OrganId, moduleSaveId, Type);
        }
        #endregion

        #region RptCodingTurnover
        public List<OBJ_RptCodingTurnover> RptCodingTurnover(int CodingDetailId, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId, out ClsError error)
        {
            error = new ClsError();
            if (CodingDetailId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodingStatus.RptCodingTurnover(CodingDetailId, CaseTypeId, SourceId, Year, OrganId, moduleSaveId);
        }
        #endregion
        #region RptCodingTurnover_Tarikh
        public List<OBJ_RptCodingTurnover> RptCodingTurnover_Tarikh(int CodingDetailId, int CaseTypeId, int SourceId, short Year, int OrganId, 
            int moduleSaveId,string AzTarikh,string TaTarikh, out ClsError error)
        {
            error = new ClsError();
            if (CodingDetailId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodingStatus.spr_RptCodingTurnover_Tarikh(CodingDetailId, CaseTypeId, SourceId, Year, OrganId, moduleSaveId,AzTarikh,TaTarikh);
        }
        #endregion

        #region RptDafater
        public List<OBJ_Dafater> RptDafater(string AzCode, string TaCode, int AzSanad, int TaSanad, byte Group, int FiscalYearId, int CaseTypeId, int SourceId)
        {
            return CodingStatus.RptDafater(AzCode, TaCode, AzSanad, TaSanad, Group, FiscalYearId, CaseTypeId, SourceId);
        }
        #endregion
    }
}