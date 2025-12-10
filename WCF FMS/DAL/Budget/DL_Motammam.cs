using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Budget;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Motammam
    {
        #region Detail
        public OBJ_Motammam Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblMotammamSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Motammam
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldTarikh=q.fldTarikh,
                        fldYear=q.fldYear,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Motammam> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblMotammamSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Motammam()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldTarikh = q.fldTarikh,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldFiscalYearId, string fldTarikh, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblMotammamInsert(fldFiscalYearId, fldTarikh, Desc, userId, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldFiscalYearId, string fldTarikh, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblMotammamUpdate(Id, fldFiscalYearId, fldTarikh, Desc, userId, OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblMotammamDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}