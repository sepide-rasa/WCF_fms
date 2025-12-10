using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_TemplateCoding
    {
        #region Detail
        public OBJ_TemplateCoding Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblTemplateCodingSelect("fldId", id.ToString(),"",0,"", 1)
                    .Select(q => new OBJ_TemplateCoding
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldName = q.fldName,
                        fldCode = q.fldCode,
                        fldItemId = q.fldItemId,
                        fldMahiyatId = q.fldMahiyatId,
                        fldPCod = q.fldPCod,
                        fldLevelsAccountTypId = q.fldLevelsAccountTypId,
                        fldTempNameId = q.fldTempNameId,
                        fldTemplateName = q.fldTemplateName,
                        fldNameItem = q.fldNameItem,
                        fldTitle_Mahiyat = q.fldTitle_Mahiyat,
                        fldName_LevelsAccountingType = q.fldName_LevelsAccountingType,
                        fldNameTypeHesab = q.fldNameTypeHesab,
                        fldTypeHesabId = q.fldTypeHesabId,
                        fldDaramadCode=q.fldDaramadCode,
                        fldAddChildNode=q.fldAddChildNode,
                        fldCodeBudget = q.fldCodeBudget,
                        fldMahiyat_GardeshId = q.fldMahiyat_GardeshId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TemplateCoding> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int HeaderCodingId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblTemplateCodingSelect(FieldName, FilterValue, FilterValue2,HeaderCodingId,FilterValue3, h)
                    .Select(q => new OBJ_TemplateCoding()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldName = q.fldName,
                        fldCode = q.fldCode,
                        fldItemId = q.fldItemId,
                        fldMahiyatId = q.fldMahiyatId,
                        fldPCod = q.fldPCod,
                        fldLevelsAccountTypId = q.fldLevelsAccountTypId,
                        fldTempNameId = q.fldTempNameId,
                        fldTemplateName = q.fldTemplateName,
                        fldNameItem = q.fldNameItem,
                        fldTitle_Mahiyat = q.fldTitle_Mahiyat,
                        fldName_LevelsAccountingType = q.fldName_LevelsAccountingType,
                        fldNameTypeHesab = q.fldNameTypeHesab,
                        fldTypeHesabId = q.fldTypeHesabId,
                        fldDaramadCode = q.fldDaramadCode,
                        fldAddChildNode = q.fldAddChildNode,
                        fldCodeBudget = q.fldCodeBudget,
                        fldMahiyat_GardeshId = q.fldMahiyat_GardeshId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(Nullable<int> PID, Nullable<int> ItemId, string Name, string PCod, int MahiyatId,int? Mahiyat_GardeshId, string Code, int TempNameId, int LevelsAccountTypId, byte fldTypeHesabId,Boolean? AddChildNode,string CodeBudget, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTemplateCodingInsert(PID, ItemId, Name, PCod, MahiyatId, Code, TempNameId, LevelsAccountTypId, fldTypeHesabId, Desc, IP, UserId, CodeBudget, AddChildNode, Mahiyat_GardeshId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, Nullable<int> ItemId, string Name, int MahiyatId,int? Mahiyat_GardeshId, string Code, int TempNameId, int LevelsAccountTypId, byte fldTypeHesabId, Boolean? AddChildNode, string CodeBudget, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTemplateCodingUpdate(Id, ItemId, Name, MahiyatId, Code, TempNameId, LevelsAccountTypId, fldTypeHesabId, Desc, IP, UserId, CodeBudget, AddChildNode, Mahiyat_GardeshId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTemplateCodingDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckValidCode
        public int CheckValidCode(int AccountTypId, string Code, string PCod,int Id,int TempNameId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var fldValid = p.CheckValidCode(AccountTypId, Code, PCod, Id, TempNameId).FirstOrDefault().fldValid;
                return fldValid;   
            }
        }
        #endregion
        #region GetDefaultCode
        public List<OBJ_TemplateCoding> GetDefaultCode(int AccountTypId, string PCod,int TempNameId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.GetDefaultCode(AccountTypId, PCod, TempNameId)
                    .Select(q => new OBJ_TemplateCoding()
                    {
                        fldCode = q.fldCode,
                        fldName_LevelsAccountingType = q.fldLevelName,
                        fldLevelsAccountTypId = q.LevelId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int TempNameId, string Code, int Id)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblTemplateCodingSelect("fldTempNameId", TempNameId.ToString(), Code,0,"", 0).Any();

                }
                else
                {
                    var query = p.spr_tblTemplateCodingSelect("fldTempNameId", TempNameId.ToString(), Code,0,"", 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var Coding_D = p.spr_tblCoding_DetailsSelect("fldTempCodingId", id.ToString(), "","", 0).FirstOrDefault();
                if (Coding_D != null)
                    q = true;
            }
            return q;
        }
        #endregion
        
    }
}