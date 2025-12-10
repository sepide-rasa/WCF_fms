using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_CenterCost
    {
        #region Detail
        public OBJ_CenterCost Detail(int id,int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblCenterCostSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_CenterCost
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldNameCenter = q.fldNameCenter,
                        fldOrganId = q.fldOrganId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CenterCost> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblCenterCostSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_CenterCost()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldNameCenter = q.fldNameCenter,
                        fldOrganId = q.fldOrganId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string NameCenter,int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCenterCostInsert(OrganId, NameCenter, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string NameCenter, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCenterCostUpdate(Id,OrganId, NameCenter, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCenterCostDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdatePID_Cost_Tree
        public string UpdatePID_Cost_Tree(int Cost_TreeId, int Parent, int UserId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_UpdatePID_Cost_Tree(Cost_TreeId, Parent, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string NameCenter, int OrganId, int Id)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblCenterCostSelect("fldNameCenter", NameCenter, OrganId, 0).Any();

                }
                else
                {
                    var query = p.spr_tblCenterCostSelect("fldNameCenter", NameCenter, OrganId, 0).FirstOrDefault();
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
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var datail = p.spr_tblDocumentRecord_DetailsSelect("fldCenterCoId", Id.ToString(), 0).FirstOrDefault();
                if (datail != null)
                    q = true;
            }
            return q;
        }
        #endregion
        public int IsCostCenter(int CodingId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var Flag = p.spr_IsCostCenter(CodingId).FirstOrDefault().Cost;
                return Flag;
            }            
        }
    }
}