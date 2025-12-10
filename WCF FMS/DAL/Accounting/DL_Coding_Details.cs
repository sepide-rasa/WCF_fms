using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_Coding_Details
    {
        #region Detail
        public OBJ_Coding_Details Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblCoding_DetailsSelect("fldId", id.ToString(),"","", 1)
                    .Select(q => new OBJ_Coding_Details
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldAccountLevelId = q.fldAccountLevelId,
                        fldCode = q.fldCode,
                        fldName_AccountingLevel = q.fldName_AccountingLevel,
                        fldName_TemplateCoding = q.fldName_TemplateCoding,
                        fldOrganId = q.fldOrganId,
                        fldPCod = q.fldPCod,
                        fldTempCodingId = q.fldTempCodingId,
                        fldTitle = q.fldTitle,
                        fldYear = q.fldYear,
                        fldMahiyatId = q.fldMahiyatId,
                        fldAccountingTypeId=q.fldAccountingTypeId,
                        fldTempNameId = q.fldTempNameId,
                        fldHeaderCodId = q.fldHeaderCodId,
                        fldTypeHesabId = q.fldTypeHesabId,
                        fldNameTypeHesab = q.fldNameTypeHesab,
                        fldDaramadCode=q.fldDaramadCode,
                        fldItemIdParent = q.fldItemIdParent,
                        lastNode = q.LastNod,
                        fldMahiyat_GardeshId = q.fldMahiyat_GardeshId,
                        fldItemId=q.fldItemId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region GetItemId
        public int GetItemId(int HeaderId,int PId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                int ItemId = 0;
                var k = p.spr_selectExistsItemDaramad(PId, HeaderId).FirstOrDefault();
                if (k != null)
                    ItemId = k.fldItemId;
                return ItemId;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Coding_Details> Select(string FieldName, string FilterValue, string FilterValue2,string FilterValue3, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblCoding_DetailsSelect(FieldName, FilterValue,FilterValue2,FilterValue3, h)
                    .Select(q => new OBJ_Coding_Details()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldAccountLevelId = q.fldAccountLevelId,
                        fldCode = q.fldCode,
                        fldName_AccountingLevel = q.fldName_AccountingLevel,
                        fldName_TemplateCoding = q.fldName_TemplateCoding,
                        fldOrganId = q.fldOrganId,
                        fldPCod = q.fldPCod,
                        fldTempCodingId = q.fldTempCodingId,
                        fldTitle = q.fldTitle,
                        fldYear = q.fldYear,
                        fldMahiyatId = q.fldMahiyatId,
                        fldAccountingTypeId = q.fldAccountingTypeId,
                        fldTempNameId = q.fldTempNameId,
                        fldHeaderCodId = q.fldHeaderCodId,
                        fldTypeHesabId = q.fldTypeHesabId,
                        fldNameTypeHesab = q.fldNameTypeHesab,
                        fldDaramadCode=q.fldDaramadCode,
                        fldItemIdParent = q.fldItemIdParent,
                        lastNode = q.LastNod,
                        fldMahiyat_GardeshId = q.fldMahiyat_GardeshId,
                        fldItemId = q.fldItemId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectCoding_Project
        public List<OBJ_Coding_ProjeFaaliat> SelectCoding_Project(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblCoding_ProjeFaaliatSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Coding_ProjeFaaliat()
                    {
                        fldId = q.fldId,
                        fldCodingDetailId=q.fldCodingDetailId,
                        fldCodingTitle=q.fldCodingTitle,
                        fldCodeAcc=q.fldCodeAcc,
                        fldMahiyatId=q.fldMahiyatId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int HeaderId, Nullable<int> PID, string PCod, int? TempCodingId, string Title, string Code,string CodeDaramad, int AccountLevelId, int MahiyatId,int? Mahiyat_GardeshId, byte TypeHesabId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCoding_DetailsInsert(PID, PCod, TempCodingId, Title, Code, CodeDaramad, AccountLevelId, TypeHesabId, Desc, IP, UserId, MahiyatId, HeaderId, Mahiyat_GardeshId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int HeaderId, int? TempCodingId, string Title, string Code,string CodeDaramad, int AccountLevelId, int MahiyatId, int? Mahiyat_GardeshId,byte TypeHesabId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCoding_DetailsUpdate(Id, TempCodingId, Title, Code, CodeDaramad, AccountLevelId, TypeHesabId, Desc, IP, UserId, MahiyatId, HeaderId, Mahiyat_GardeshId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCoding_DetailsDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region GetDefaultCode_Coding
        public List<OBJ_Coding_Details> GetDefaultCode_Coding(int HeaderId, string PCode)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.GetDefaultCode_Coding(HeaderId, PCode)
                    .Select(q => new OBJ_Coding_Details()
                    {
                        fldCode = q.fldCode,
                        fldName_AccountingLevel = q.fldLevelName,
                        fldAccountLevelId = q.LevelId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckValidCode_CodingDetail
        public int CheckValidCode_CodingDetail(int HeaderId, string Code, string PCode, int Id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var fldValid = p.CheckValidCode_CodingDetail(HeaderId, Code, PCode, Id).FirstOrDefault().fldValid;
                return fldValid;
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (AccountingEntities m = new AccountingEntities())
            {
              var detail=  m.spr_tblDocumentRecord_DetailsSelect("fldCodingId", id.ToString(), 0).FirstOrDefault();
              if (detail != null)
                  q = true;
            }
            return q;
        }
        #endregion
        #region CheckDelete2
        public bool CheckDelete2(int id)
        {
            var q = false;
            using (AccountingEntities m = new AccountingEntities())
            {
                var Rec = m.spr_tblCoding_DetailsSelect("fldId", id.ToString(), "", "", 1).FirstOrDefault();
                var detail = m.spr_tblCoding_DetailsSelect("fldCode", Rec.fldPCod, Rec.fldHeaderCodId.ToString(), "", 1).FirstOrDefault();
                if (detail != null)
                    q = detail.fldAddChildNode;
            }
            return q;
        }
        #endregion
        #region CheckAllowedInsert_Update
        public bool CheckAllowedInsert_Update(string Code,int HeaderId,int ID)
        {
            var q = false;
            using (AccountingEntities m = new AccountingEntities())
            {
                if (ID != 0)/*مود ویرایش*/
                {
                    var Rec = m.spr_tblCoding_DetailsSelect("fldCode", Code, HeaderId.ToString(), "", 1).FirstOrDefault();
                    Code = Rec.fldPCod;
                }
                var detail = m.spr_tblCoding_DetailsSelect("fldCode", Code, HeaderId.ToString(), "", 1).FirstOrDefault();
                if (detail != null)
                    q = detail.fldAddChildNode;
            }
            return q;
        }
        #endregion
        #region RptByCoding
        public OBJ_RptByCoding RptByCoding(int CodingId, int OrganId, short Year, byte ModuleId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_RptByCoding(CodingId, OrganId, Year,ModuleId)
                    .Select(q => new OBJ_RptByCoding()
                    {
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        GardeshHesab = q.GardeshHesab,
                        MandehHeasb = q.MandehHeasb,
                        fldTitle = q.fldTitle,
                        fldType = q.fldType
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion


        #region CheckMahiyatGardesh_Mande
        public List<OBJ_CheckMahiyatGardesh_Mande> CheckMahiyatGardesh_Mande(int Id,int organid,short year,long bed,long best,int idDetail,int moduleSaveId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_CheckMahiyatGardesh_Mande(organid,year,bed,best,idDetail,moduleSaveId,Id)
                    .Select(q => new OBJ_CheckMahiyatGardesh_Mande()
                    {
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldMahiyat_GardeshId = q.fldMahiyat_GardeshId,
                        fldMahiyatGardesh=q.fldMahiyatGardesh,
                        fldMahiyatId=q.fldMahiyatId,
                        fldMahiyatMonde=q.fldMahiyatMonde
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}