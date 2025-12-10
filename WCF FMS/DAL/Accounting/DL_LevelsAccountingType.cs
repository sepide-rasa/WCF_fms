using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_LevelsAccountingType
    {
        #region Detail
        public OBJ_LevelsAccountingType Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblLevelsAccountingTypeSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_LevelsAccountingType
                    {
                        fldId = q.fldId,
                        flddate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldName = q.fldName,
                        fldAccountTypeId=q.fldAccountTypeId,
                        fldArghumNum=q.fldArghumNum,
                        fldName_AccountingType = q.fldName_AccountingType,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LevelsAccountingType> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblLevelsAccountingTypeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_LevelsAccountingType()
                    {
                        fldId = q.fldId,
                        flddate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldName = q.fldName,
                        fldAccountTypeId = q.fldAccountTypeId,
                        fldArghumNum = q.fldArghumNum,
                        fldName_AccountingType = q.fldName_AccountingType,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name, int AccountTypeId, int ArghumNum, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblLevelsAccountingTypeInsert(Name, AccountTypeId, ArghumNum, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int AccountTypeId, int ArghumNum, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblLevelsAccountingTypeUpdate(Id, Name, AccountTypeId, ArghumNum, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblLevelsAccountingTypeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region selectAccountingTypeLevel
        public List<OBJ_LevelsAccountingType> selectAccountingTypeLevel(int AccountTypeId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_selectAccountingTypeLevel(AccountTypeId)
                    .Select(q => new OBJ_LevelsAccountingType()
                    {
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldAccountTypeId = q.fldAccountTypeId,
                        fldArghumNum = q.fldArghumNum,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q=false;
            using (AccountingEntities m = new AccountingEntities())
            {
                var Template = m.spr_tblTemplateCodingSelect("fldLevelsAccountTypId", id.ToString(), "",0,"", 0).FirstOrDefault();
                if (Template != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}