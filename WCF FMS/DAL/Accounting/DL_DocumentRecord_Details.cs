using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_DocumentRecord_Details
    {
        #region Detail
        public OBJ_DocumentRecord_Details Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblDocumentRecord_DetailsSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_DocumentRecord_Details
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldCaseId = q.fldCaseId,
                        fldCenterCoId = q.fldCenterCoId,
                        fldCodingId = q.fldCodingId,
                        fldDescription = q.fldDescription,
                        fldDocument_HedearId = q.fldDocument_HedearId,
                        fldSourceId=q.fldSourceId,
                        fldCaseTypeId = q.fldCaseTypeId,
                        fldName=q.fldName,
                        fldNameCenter=q.fldNameCenter,
                        fldOrder = q.fldOrder,
                        fldCode = q.fldCode,
                        fldNameCoding = q.fldNameCoding,
                        fldName_CodeDetail = q.fldName_CodeDetail
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DocumentRecord_Details> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblDocumentRecord_DetailsSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DocumentRecord_Details()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldCaseId = q.fldCaseId,
                        fldCenterCoId = q.fldCenterCoId,
                        fldCodingId = q.fldCodingId,
                        fldDescription = q.fldDescription,
                        fldDocument_HedearId = q.fldDocument_HedearId,
                        fldSourceId = q.fldSourceId,
                        fldCaseTypeId = q.fldCaseTypeId,
                        fldName = q.fldName,
                        fldNameCenter = q.fldNameCenter,
                        fldOrder = q.fldOrder,
                        fldCode = q.fldCode,
                        fldNameCoding = q.fldNameCoding,
                        fldName_CodeDetail=q.fldName_CodeDetail,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectHesabDaryaftani
        public List<OBJ_DocumentRecord_Details> SelectHesabDaryaftani(string FieldName,int FiscalYearId, int ShomareHesabId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectHesabDaryaftani(FieldName,FiscalYearId, ShomareHesabId)
                    .Select(q => new OBJ_DocumentRecord_Details()
                    {
                        fldBedehkar=q.fldBedehkar,
                        fldBestankar=q.fldBestankar,
                        fldName=q.fldName,
                        fldCode=q.fldCode,
                        fldNameCoding=q.fldNameCoding,
                        fldMande=q.fldMande,
                        fldSerialFish=q.fldSerialFish,
                        fldNameShakhs=q.fldNameShakhs,
                        fldElamAvarezId=q.fldElamAvarezId,
                        fldModuleErsalId=q.fldModuleErsalId,
                       fldCaseTypeName=q.fldCaseTypeName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectEkhtetamiye
        public List<OBJ_DocumentRecord_Details> SelectEkhtetamiye(int FiscalYearId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectDocumentEkhtetamiye(FiscalYearId,2)
                    .Select(q => new OBJ_DocumentRecord_Details()
                    {
                        fldId =0,
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldCaseId = q.fldCaseId,
                        fldCenterCoId = q.fldCenterCoId,
                        fldCodingId = q.fldCodingId,
                        fldDescription = "سند اختتامیه",
                        fldSourceId = q.fldSourceId,
                        fldCaseTypeId = q.fldCaseTypeId,
                        fldName = q.fldName,
                        fldNameCenter = "",
                        fldOrder = 0,
                        fldNameCoding = q.fldTitle,
                        fldName_CodeDetail = q.fldName_CodeDetail
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectBastanHesabha
        public List<OBJ_DocumentRecord_Details> SelectBastanHesabha(int FiscalYearId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectBastanHesabha(FiscalYearId)
                    .Select(q => new OBJ_DocumentRecord_Details()
                    {
                        fldId = 0,
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldCaseId = q.fldCaseId,
                        fldCenterCoId = q.fldCenterCoId,
                        fldCodingId = q.fldCodingId,
                        fldDescription = "بستن حسابهای موقت",
                        fldSourceId = q.fldSourceId,
                        fldCaseTypeId = q.fldCaseTypeId,
                        fldName = q.fldName,
                        fldNameCenter = "",
                        fldOrder = 0,
                        fldNameCoding = q.fldTitle,
                        fldName_CodeDetail = q.fldName_CodeDetail
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectEftetahiye
        public List<OBJ_DocumentRecord_Details> SelectEftetahiye(int FiscalYearId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectDocumentEkhtetamiye(FiscalYearId,1)
                    .Select(q => new OBJ_DocumentRecord_Details()
                    {
                        fldId = 0,
                        fldBedehkar = q.fldBestankar,
                        fldBestankar = q.fldBedehkar,
                        fldCaseId = q.fldCaseId,
                        fldCenterCoId = q.fldCenterCoId,
                        fldCodingId = q.fldCodingId,
                        fldDescription = "سند افتتاحیه",
                        fldSourceId = q.fldSourceId,
                        fldCaseTypeId = q.fldCaseTypeId,
                        fldName = q.fldName,
                        fldNameCenter = "",
                        fldOrder = 0,
                        fldNameCoding = q.fldTitle,
                        fldName_CodeDetail = q.fldName_CodeDetail
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectDocFiles
        public List<OBJ_DocFiles> SelectDocFiles(short Year, int OrganId, int CodingId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectDocumentRecord_ComboBox(Year, OrganId, CodingId)
                    .Select(q => new OBJ_DocFiles()
                    {
                        fldId = q.fldId,
                        fldCaseTypeId=q.fldCaseTypeId,
                        fldName=q.fldName
                    }).ToList();
                return test;
            }
        }
        #endregion
        //#region Insert
        //public string Insert(int HeaderId, int CodingId, string Description, long BedehKar, long BestanKar, int? CenterCoId, int CaseTypeId,int SourceId, int UserId, string IP, string Desc)
        //{
        //    using (AccountingEntities p = new AccountingEntities())
        //    {
        //        p.spr_tblDocumentRecord_DetailsInsert(HeaderId, CodingId, Description, BedehKar, BestanKar, CenterCoId, CaseTypeId, SourceId, Desc, IP, UserId);
        //        return "ذخیره با موفقیت انجام شد.";
        //    }
        //}
        //#endregion
        //#region Update
        //public string Update(int Id, int HeaderId, int CodingId, string Description, long BedehKar, long BestanKar, int? CenterCoId, int CaseId,int CaseTypeId,int SourceId, int UserId, string IP, string Desc)
        //{
        //    using (AccountingEntities p = new AccountingEntities())
        //    {
        //        p.spr_tblDocumentRecord_DetailsUpdate(Id, HeaderId, CodingId, Description, BedehKar, BestanKar, CenterCoId, CaseId, CaseTypeId, SourceId, Desc, IP, UserId);
        //        return "ویرایش با موفقیت انجام شد.";
        //    }
        //}
        //#endregion
        #region Delete
        public string Delete(string FieldName,int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentRecord_DetailsDelete(FieldName, id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region DeleteDocumentDetail
        public string DeleteDocumentDetail(int HeaderId, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_DocumentDetailDelete(HeaderId, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}