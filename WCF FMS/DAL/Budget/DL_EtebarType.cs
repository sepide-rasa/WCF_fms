using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Budget;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Budget
{
    public class DL_EtebarType
    {
        #region Detail
        public OBJ_EtebarType Detail(int id,int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblEtebarTypeSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_EtebarType
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId=q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_EtebarType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblEtebarTypeSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_EtebarType()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title,int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblEtebarTypeInsert(Title, OrganId, Desc, userId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblEtebarTypeUpdate(Id, Title,OrganId, Desc, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblEtebarTypeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}