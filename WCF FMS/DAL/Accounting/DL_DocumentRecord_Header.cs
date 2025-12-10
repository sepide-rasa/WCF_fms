using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_DocumentRecord_Header
    {
        #region Detail
        public OBJ_DocumentRecord_Header Detail(int id, int OrganId, short Year, int Madule)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblDocumentRecord_HeaderSelect("fldId", id.ToString(),"","", OrganId, Year, Madule,1, 1)
                    .Select(q => new OBJ_DocumentRecord_Header
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldArchiveNum = q.fldArchiveNum,
                        fldAtfNum = q.fldAtfNum,
                        fldDescriptionDocu = q.fldDescriptionDocu,
                        fldDocumentNum = q.fldDocumentNum,
                        fldOrganId = q.fldOrganId,
                        fldTarikhDocument = q.fldTarikhDocument,
                        fldAccept = q.fldAccept,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        ShomareRoozane = q.ShomareRoozane,
                        fldShomareFaree = q.fldShomareFaree,
                        fldYear = q.fldYear,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldNameModule = q.fldNameModule,
                        fldModuleErsalId = q.fldModuleErsalId,
                        fldIsArchive = q.fldIsArchive,
                        fldDocumentNum_Pid=q.fldDocumentNum_Pid,
                        fldTypeSanadName_Pid=q.fldTypeSanadName_Pid,
                        fldPId=q.fldPId,
                        fldMainDocNum = q.fldMainDocNum,
                        fldFlag=q.fldFlag,
                        fldIsMap=q.fldIsMap,
                        fldEdit=q.fldEdit,
                        fldCaseTypeId=q.fldCaseTypeId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DocumentRecord_Header> Select(string FieldName, string FilterValue,string value2,string value3, int OrganId, short Year, int Madule,byte OrderType, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblDocumentRecord_HeaderSelect(FieldName, FilterValue,value2,value3, OrganId,Year,Madule,OrderType, h)
                    .Select(q => new OBJ_DocumentRecord_Header()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldArchiveNum = q.fldArchiveNum,
                        fldAtfNum = q.fldAtfNum,
                        fldDescriptionDocu = q.fldDescriptionDocu,
                        fldDocumentNum = q.fldDocumentNum,
                        fldOrganId = q.fldOrganId,
                        fldTarikhDocument = q.fldTarikhDocument,
                        fldAccept = q.fldAccept,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        ShomareRoozane = q.ShomareRoozane,
                        fldShomareFaree = q.fldShomareFaree,
                        fldYear = q.fldYear,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldNameModule = q.fldNameModule,
                        fldModuleErsalId = q.fldModuleErsalId,
                        fldIsArchive = q.fldIsArchive,
                        fldDocumentNum_Pid = q.fldDocumentNum_Pid,
                        fldTypeSanadName_Pid=q.fldTypeSanadName_Pid,
                        fldPId = q.fldPId,
                        fldMainDocNum=q.fldMainDocNum,
                        fldFlag = q.fldFlag,
                        fldIsMap = q.fldIsMap,
                        fldEdit = q.fldEdit,
                        fldCaseTypeId = q.fldCaseTypeId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectMortabet
        public List<OBJ_DocumentRecord_Header> SelectMortabet(int HeaderId, int MaduleSaveId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectMortabet(HeaderId, MaduleSaveId)
                    .Select(q => new OBJ_DocumentRecord_Header()
                    {
                        fldId = q.fldId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public int Insert(int DocumentNum, string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept,byte Type, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
               var id= p.spr_tblDocumentRecord_HeaderInsert(DocumentNum, ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Desc, IP, UserId, Accept,Type);
                return Convert.ToInt32(id);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept, byte Type, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentRecord_HeaderUpdate(Id, ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Desc, IP, UserId, Accept,Type);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentRecord_HeaderDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        /*#region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var Detail = p.spr_tblDocumentRecord_DetailsSelect("fldDocument_HedearId", Id.ToString(), 0).FirstOrDefault();
                if (Detail != null)
                    q = true;
            }
            return q;
        }
        #endregion*/

        #region LastNum_AtfDocumentRecord
        public List<OBJ_DocumentRecord_Header> LastNum_AtfDocumentRecord(short Year, int OrganId, int ModuleDocId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_LastNum_AtfDocumentRecord(Year,OrganId,ModuleDocId)
                    .Select(q => new OBJ_DocumentRecord_Header()
                    {
                        fldAtfNum = q.AtfNum,
                        fldDocumentNum = q.fldDocumentNum,
                        ShomareRoozane = q.ShomareRoozane
                    }).ToList();
                return test;
            }
        }
        #endregion
         
        #region InsertDocument
        public int InsertDocument( string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept, byte Type, System.Data.DataTable detail, 
            int? ModuleSaveId, int? ModuleErsalId, Nullable<int> fldShomareFaree, int fldFiscalYearId, int fldTypeSanad,int? fldPid,byte? fldEdit, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter fldDocumentNum = new System.Data.Entity.Core.Objects.ObjectParameter("fldDocumentNum", typeof(int));
                return p.spr_DocumentInsert(fldDocumentNum, ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Desc, IP, UserId, Accept, Type, ModuleSaveId, ModuleErsalId,
                    fldShomareFaree, fldFiscalYearId, fldTypeSanad,fldPid,fldEdit, detail);
            }
        }
        #endregion
        #region UpdateDocument
        public string UpdateDocument(int fldHeaderId, int DocumentNum, string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept, byte Type, System.Data.DataTable detail, int? ModuleSaveId, int? ModuleErsalId, Nullable<int> fldShomareFaree, int fldTypeSanad, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_DocumentUpdate(fldHeaderId, DocumentNum, ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Desc, IP, UserId, Accept, Type, ModuleSaveId, ModuleErsalId, fldShomareFaree, fldTypeSanad, detail);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertDocumentFishDaramad
        public string InsertDocumentFishDaramad(int FiscalYearId, int FishId, int OrganId,int ModuleSaveId, int ModuleErsalId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_DocumentInsert_DaramadFish(FiscalYearId, FishId, OrganId, Desc, IP, UserId, ModuleSaveId, ModuleErsalId);
                return "ثبت سند فیش درآمد با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateMoratabSaziTarikhSanad
        public string UpdateMoratabSaziTarikhSanad(int OrganId, short Year, int moduleId, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_SelectMoratabSaziTarikhSanad(OrganId,Year,moduleId,userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckRemain
        public List<OBJ_CheckRemain> CheckRemain(int Coding_DetailsId, int id, long Bedehkar, long Bestankar, int OrganId, short Year, int MaduleSaveId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_CheckRemain(Coding_DetailsId, id, Bedehkar, Bestankar, Year, OrganId, MaduleSaveId)
                    .Select(q => new OBJ_CheckRemain()
                    {
                        fldCheck = q.fldCheck,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region UpdateGhati
        public string UpdateGhati(int fldHeaderId,int UserId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentRecord_Ghati(fldHeaderId, UserId);
                return "سند با موفقیت قطعی شد.";
            }
        }
        #endregion
        #region CheckDocStatus
        public bool CheckDocStatus(int DocHeaderId, out int Id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var q = p.spr_CheckDocStatus(DocHeaderId).FirstOrDefault();
                Id =Convert.ToInt32(q.Id);
                return Convert.ToBoolean(q.DocStatus);
            }
        }
        #endregion
        #region Document_CopyInsert
        public string Document_CopyInsert(int DocHeaderId, int OrganId, byte ModuleErsalId,byte ModuleSaveId, byte Type,string TarikhDocument, int UserId, string IP)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_Document_CopyInsert(DocHeaderId, OrganId, ModuleErsalId,ModuleSaveId,Type,TarikhDocument, IP, UserId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CopyDocumentWithHeaderId
        public string CopyDocumentWithHeaderId(int DocHeaderId,  int UserId, string IP)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_CopyDocumentWithHeaderId(DocHeaderId,  UserId,IP);
                return "کپی سند با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateArchive_FareiNum
        public string UpdateArchive_FareiNum(int fldHeaderId,string ArchiveNum,int FareiNum, int UserId,string Ip)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentRecord_Header1Update(fldHeaderId,ArchiveNum,FareiNum,Ip,UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region DisableGhati
        public string DisableGhati(int fldHeaderId, int UserId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_UpdateExitGhateeiDocument(fldHeaderId, UserId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        
    }
}