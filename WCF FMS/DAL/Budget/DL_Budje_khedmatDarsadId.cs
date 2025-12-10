using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Budget;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Budje_khedmatDarsadId
    {
        #region Detail
        public OBJ_Budje_khedmatDarsadId Detail(int id)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblBudje_khedmatDarsadIdSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_Budje_khedmatDarsadId
                    {
                        fldBudje_khedmatDarsadId = q.fldBudje_khedmatDarsadId,
                        fldDate = q.fldDate,
                        fldCodingAcc_detailId = q.fldCodingAcc_detailId,
                        fldUserId = q.fldUserId,
                        fldCodingBudje_DetailsId = q.fldCodingBudje_DetailsId,
                        fldDarsad = q.fldDarsad,
                        fldCodeAcc=q.fldCodeAcc,
                        fldCodeBudje=q.fldCodeBudje,
                        fldTitleAcc=q.fldTitleAcc,
                        fldTitleBudje=q.fldTitleBudje
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Budje_khedmatDarsadId> Select(string FieldName, string FilterValue, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblBudje_khedmatDarsadIdSelect(FieldName, FilterValue,  h)
                    .Select(q => new OBJ_Budje_khedmatDarsadId()
                    {
                        fldBudje_khedmatDarsadId = q.fldBudje_khedmatDarsadId,
                        fldDate = q.fldDate,
                        fldCodingAcc_detailId = q.fldCodingAcc_detailId,
                        fldUserId = q.fldUserId,
                        fldCodingBudje_DetailsId = q.fldCodingBudje_DetailsId,
                        fldDarsad = q.fldDarsad,
                        fldCodeAcc = q.fldCodeAcc,
                        fldCodeBudje = q.fldCodeBudje,
                        fldTitleAcc = q.fldTitleAcc,
                        fldTitleBudje = q.fldTitleBudje
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingAcc_detailId, int? fldCodingBudje_DetailsId, int userId, double fldDarsad, System.Data.DataTable Pishbini)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblBudje_khedmatDarsadIdInsert(fldCodingAcc_detailId, fldCodingBudje_DetailsId, fldDarsad, userId,Pishbini);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertOnlyKhedmat
        public string InsertOnlyKhedmat(int fldCodingAcc_detailId, int fldCodingBudje_DetailsId, int userId, double fldDarsad)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblBudje_khedmatDarsadIdInsert(fldCodingAcc_detailId, fldCodingBudje_DetailsId, fldDarsad, userId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldCodingAcc_detailId, int fldCodingBudje_DetailsId, int userId, double fldDarsad)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblBudje_khedmatDarsadIdUpdate(Id, fldCodingAcc_detailId, fldCodingBudje_DetailsId, fldDarsad, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblBudje_khedmatDarsadIdDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}