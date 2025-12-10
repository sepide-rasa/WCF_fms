using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_RptCodingStatus
    {
        #region RptCodingStatus
        public List<OBJ_RptCodingStatus> RptCodingStatus(int CodingDetailId, byte flag, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId,byte Type)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_RptCodingStatus(CodingDetailId, flag, CaseTypeId, SourceId, Year, OrganId,moduleSaveId, Type)
                    .Select(q => new OBJ_RptCodingStatus()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldParentTitle = q.fldParentTitle,
                        fldTypeName = q.fldTypeName,
                        fldType = q.fldType,
                        fldMande = q.fldMande,
                        fldNoe_Mahiyat = q.fldNoe_Mahiyat
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region RptCodingStatus_Parvande
        public List<OBJ_RptCodingStatus> RptCodingStatus_Parvande(int CodingDetailId, byte flag, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId, byte Type)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_RptCodingStatus_Parvande(CodingDetailId, flag, CaseTypeId, SourceId, Year, OrganId, moduleSaveId, Type)
                    .Select(q => new OBJ_RptCodingStatus()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldParentTitle = q.fldParentTitle,
                        fldTypeName = q.fldTypeName,
                        fldType = q.fldType,
                        fldMande = q.fldMande,
                        fldParvande=q.fldParvande,
                        fldSourceId=q.fldSourceId,
                        fldCaseTypeId= q.fldCaseTypeId,
                        fldNoe_Mahiyat = q.fldNoe_Mahiyat
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region RptCodingTurnover
        public List<OBJ_RptCodingTurnover> RptCodingTurnover(int CodingDetailId, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_RptCodingTurnover(CodingDetailId, CaseTypeId, SourceId, Year, OrganId,moduleSaveId)
                    .Select(q => new OBJ_RptCodingTurnover()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldParentTitle = q.fldParentTitle,
                        fldDocumentNum = q.fldDocumentNum,
                        fldType = q.fldType,
                        fldDescriptionDocu = q.fldDescriptionDocu,
                        fldBedehkar_t = q.fldBedehkar_t,
                        fldBestankar_t = q.fldBestankar_t,
                        fldMande_t = q.fldMande_t,
                        fldTypeName_t = q.fldTypeName_t,
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldDocument_HedearId=q.fldDocument_HedearId,
                        fldParvande=q.fldParvande,
                        fldTarikhDocument=q.fldTarikhDocument
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region spr_RptCodingTurnover_Tarikh
        public List<OBJ_RptCodingTurnover> spr_RptCodingTurnover_Tarikh(int CodingDetailId, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId,
            string AzTarikh,string TaTarikh)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_RptCodingTurnover_Tarikh(CodingDetailId, CaseTypeId, SourceId, Year, OrganId, moduleSaveId,AzTarikh,TaTarikh)
                    .Select(q => new OBJ_RptCodingTurnover()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldParentTitle = q.fldParentTitle,
                        fldDocumentNum = q.fldDocumentNum,
                        fldType = q.fldType,
                        fldDescriptionDocu = q.fldDescriptionDocu,
                        fldBedehkar_t = q.fldBedehkar_t,
                        fldBestankar_t = q.fldBestankar_t,
                        fldMande_t = q.fldMande_t,
                        fldTypeName_t = q.fldTypeName_t,
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldDocument_HedearId = q.fldDocument_HedearId,
                        fldParvande=q.fldParvande,
                        fldTarikhDocument = q.fldTarikhDocument
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region RptDafater
        public List<OBJ_Dafater> RptDafater(string AzCode, string TaCode, int AzSanad, int TaSanad, byte Group,int FiscalYearId,int CaseTypeId,int SourceId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_RptDafater(AzCode, TaCode, AzSanad, TaSanad, Group, FiscalYearId, CaseTypeId, SourceId)
                    .Select(q => new OBJ_Dafater()
                    {
                        fldCode=q.fldCode,
                        fldTitle =q.fldTitle,
                        fldBedehkar =q.fldBedehkar,
                        fldBestankar=q.fldBestankar, 
                        fldDocumentNum =q.fldDocumentNum,
                        fldTarikhDocument =q.fldTarikhDocument,
                        fldDescriptionDocu =q.fldDescriptionDocu,
                        fldMande=q.fldMande
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}