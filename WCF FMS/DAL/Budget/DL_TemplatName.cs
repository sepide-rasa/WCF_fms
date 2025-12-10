using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_TemplatName
    {
        #region Detail
        public OBJ_TemplatName Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblTemplatNameSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_TemplatName
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TemplatName> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblTemplatNameSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_TemplatName()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int OrganId, int userId, string Desc,string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTemplatNameInsert(fldName, userId, OrganId, Desc,IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int OrganId, int userId, string Desc,string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTemplatNameUpdate(Id, fldName, userId, OrganId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTemplatNameDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string fldName, int OrganId, int Id)
        {
            bool q = false;
            using (BudgetEntities p = new BudgetEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblTemplatNameSelect("fldName", fldName.ToString(), OrganId, 0).Any();

                }
                else
                {
                    var query = p.spr_tblTemplatNameSelect("fldName", fldName.ToString(), OrganId, 0).FirstOrDefault();
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
            using (BudgetEntities p = new BudgetEntities())
            {
                var P = p.spr_tblTemplatCodingSelect("CheckfldTemplatNameId", Id.ToString(),"", 0, 0).FirstOrDefault();
                if (P != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}