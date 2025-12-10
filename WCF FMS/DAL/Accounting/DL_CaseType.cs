using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_CaseType
    {
        #region Detail
        public OBJ_CaseType Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblCaseTypeSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_CaseType
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldName = q.fldName,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CaseType> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblCaseTypeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_CaseType()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldName = q.fldName,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCaseTypeInsert(Name, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCaseTypeUpdate(Id, Name, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCaseTypeDelete(id, userId);
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
                var c = p.spr_tblCaseSelect("fldCaseTypeId", id.ToString(), 0).FirstOrDefault();
                if (c != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}