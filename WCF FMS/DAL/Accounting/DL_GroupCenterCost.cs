using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_GroupCenterCost
    {
        #region Detail
        public OBJ_GroupCenterCost Detail(int id, int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblGroupCenterCostSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_GroupCenterCost
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldNameGroup = q.fldNameGroup,
                        fldOrganId = q.fldOrganId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_GroupCenterCost> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblGroupCenterCostSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_GroupCenterCost()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldNameGroup = q.fldNameGroup,
                        fldOrganId = q.fldOrganId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string NameGroup, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblGroupCenterCostInsert(OrganId, NameGroup, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string NameGroup, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblGroupCenterCostUpdate(Id, OrganId, NameGroup, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblGroupCenterCostDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var tree = p.spr_tblTreeCenterCostSelect("fldGroupCenterCoId", Id.ToString(), "", 0, 0).FirstOrDefault();
                if (tree != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}