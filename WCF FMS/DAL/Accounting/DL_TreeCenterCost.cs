using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_TreeCenterCost
    {
        #region Detail
        public OBJ_TreeCenterCost Detail(int id, int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblTreeCenterCostSelect("fldId", id.ToString(),"", OrganId, 1)
                    .Select(q => new OBJ_TreeCenterCost
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldGroupCenterCoId = q.fldGroupCenterCoId,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldPID = q.fldPID,
                        fldNodeType = q.fldNodeType,
                        fldCenter_treeId = q.fldCenter_treeId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TreeCenterCost> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblTreeCenterCostSelect(FieldName, FilterValue, FilterValue2, OrganId, h)
                    .Select(q => new OBJ_TreeCenterCost()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldGroupCenterCoId = q.fldGroupCenterCoId,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldPID = q.fldPID,
                        fldNodeType = q.fldNodeType,
                        fldCenter_treeId = q.fldCenter_treeId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name, int? PID,int GroupCenterCoId, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTreeCenterCostInsert(OrganId, GroupCenterCoId, PID, Name, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int GroupCenterCoId, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTreeCenterCostUpdate(Id, OrganId, GroupCenterCoId, Name, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblTreeCenterCostDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        
        #region UpdatePID_CostCenter
        public string UpdatePID_CostCenter(int Child, int Parent, int UserId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_UpdatePID_CostCenter(Child, Parent, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region Centerco_TarifNashodeh
        public List<OBJ_Centerco_TarifNashodeh> Centerco_TarifNashodeh(int GroupCenterCoId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_Centerco_TarifNashodeh(GroupCenterCoId)
                    .Select(q => new OBJ_Centerco_TarifNashodeh()
                    {
                        fldNameCenter = q.fldNameCenter,
                        fldCenterCoId = q.fldCenterCoId,
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}