using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_CodingDetail_CaseType
    {
        #region Detail
        public OBJ_CodingDetail_CaseType Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblCodingDetail_CaseTypeSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_CodingDetail_CaseType
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldCaseTypeId = q.fldCaseTypeId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldCodingDetailId = q.fldCodingDetailId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodingDetail_CaseType> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblCodingDetail_CaseTypeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_CodingDetail_CaseType()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldCaseTypeId = q.fldCaseTypeId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldCodingDetailId = q.fldCodingDetailId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingDetailId, int fldCaseTypeId, int UserId, string IP)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCodingDetail_CaseTypeInsert(fldCodingDetailId, fldCaseTypeId, UserId, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldCodingDetailId, int fldCaseTypeId, int UserId, string IP)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCodingDetail_CaseTypeUpdate(Id, fldCodingDetailId, fldCaseTypeId, UserId, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCodingDetail_CaseTypeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}