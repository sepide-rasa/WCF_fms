using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_AccountingLevel
    {
        #region Detail
        public OBJ_AccountingLevel Detail(int id, int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblAccountingLevelSelect("fldId", id.ToString(),"", OrganId, 1)
                    .Select(q => new OBJ_AccountingLevel
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldArghamNum = q.fldArghamNum,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear,
                        fldName = q.fldName,
                        fldLevelId = q.fldLevelId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AccountingLevel> Select(string FieldName, string FilterValue,string value2, int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblAccountingLevelSelect(FieldName, FilterValue,value2, OrganId, h)
                    .Select(q => new OBJ_AccountingLevel()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldArghamNum = q.fldArghamNum,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear,
                        fldName = q.fldName,
                        fldLevelId = q.fldLevelId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name,short Year, int ArghamNum, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblAccountingLevelInsert(Name,OrganId, Year, ArghamNum, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id,string Name, short Year, int ArghamNum, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblAccountingLevelUpdate(Id,Name, OrganId, Year, ArghamNum, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblAccountingLevelDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region SelectAccountingLevel
        public List<OBJ_AccountingLevel> SelectAccountingLevel(short Year, int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_selectAccountingLevel(Year,OrganId)
                    .Select(q => new OBJ_AccountingLevel()
                    {
                        fldArghamNum = q.fldArghamNum,
                        fldName = q.fldName,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear,
                        fldId=q.fldId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region DeleteAccountingLevel
        public string DeleteAccountingLevel(short Year, int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_DeleteAccountingLevel(Year, OrganId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckAccountingLevel
        public List<OBJ_AccountingLevel> CheckAccountingLevel(int AccountingTypeId, int OrganPostId, short Year)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.CheckAccountingLevel(AccountingTypeId, OrganPostId, Year)
                    .Select(q => new OBJ_AccountingLevel()
                    {
                        fldName = q.fldName,
                        fldId = q.fldId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var Coding_D = p.spr_tblCoding_DetailsSelect("fldAccountLevelId", id.ToString(), "","", 0).FirstOrDefault();
               if (Coding_D != null)
                   q = true;
            }
            return q;
        }
        #endregion
    }
}