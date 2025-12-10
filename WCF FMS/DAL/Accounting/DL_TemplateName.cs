using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_TemplateName
    {
        #region Detail
        public OBJ_TemplateName Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblTemplateNameSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_TemplateName
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldAccountingTypeId = q.fldAccountingTypeId,
                        fldName = q.fldName,
                        fldName_AccountingType = q.fldName_AccountingType,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TemplateName> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblTemplateNameSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_TemplateName()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldAccountingTypeId = q.fldAccountingTypeId,
                        fldName = q.fldName,
                        fldName_AccountingType = q.fldName_AccountingType,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name, int AccountingTypeId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTemplateNameInsert(Name, AccountingTypeId, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int AccountingTypeId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTemplateNameUpdate(Id, Name, AccountingTypeId, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTemplateNameDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var T = p.spr_tblTemplateCodingSelect("fldTempNameId", id.ToString(), "",0,"", 0).FirstOrDefault();
               if (T != null)
                   q = true;
            }
            return q;
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name, int AccountingTypeId, int Id)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblTemplateNameSelect("fldName", Name, 0).Where(l => l.fldAccountingTypeId == AccountingTypeId).Any();

                }
                else
                {
                    var query = p.spr_tblTemplateNameSelect("fldName", Name, 0).Where(l => l.fldAccountingTypeId == AccountingTypeId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}