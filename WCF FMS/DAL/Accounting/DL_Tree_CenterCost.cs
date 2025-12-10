using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_Tree_CenterCost
    {
        #region Detail
        public OBJ_Tree_CenterCost Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblTree_CenterCostSelect("fldId", id.ToString(),1)
                    .Select(q => new OBJ_Tree_CenterCost
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldCenterCoId = q.fldCenterCoId,
                        fldCostTreeId = q.fldCostTreeId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Tree_CenterCost> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblTree_CenterCostSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Tree_CenterCost()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldCenterCoId = q.fldCenterCoId,
                        fldCostTreeId = q.fldCostTreeId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int CenterCoId, int CostTreeId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTree_CenterCostInsert(CenterCoId, CostTreeId, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int CenterCoId, int CostTreeId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTree_CenterCostUpdate(Id, CenterCoId, CostTreeId, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTree_CenterCostDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}