using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Anticipation
    {
        #region Detail
        public OBJ_Anticipation Detail(int id)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblPishbiniSelect("fldId", id.ToString(),"",  1)
                    .Select(q => new OBJ_Anticipation
                    {
                        fldId = q.fldpishbiniId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldBudgetTypeId=q.fldBudgetTypeId,
                        fldCodingAcc_DetailsId = q.fldCodingAcc_DetailsId,
                        fldCodingBudje_DetailsId = q.fldCodingBudje_DetailsId,
                        fldMablagh=q.fldMablagh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Anticipation> Select(string FieldName, string FilterValue,string FilterValue2,  int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblPishbiniSelect(FieldName, FilterValue,FilterValue2, h)
                    .Select(q => new OBJ_Anticipation()
                    {
                        fldId = q.fldpishbiniId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldBudgetTypeId = q.fldBudgetTypeId,
                        fldCodingAcc_DetailsId = q.fldCodingAcc_DetailsId,
                        fldCodingBudje_DetailsId = q.fldCodingBudje_DetailsId,
                        fldMablagh = q.fldMablagh,
                        fldMotammamId=q.fldMotammamId,
                        fldTitleAcc=q.fldTitle
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingAcc_DetailsId, int? fldCodingBudje_DetailsId, System.Data.DataTable Pishbini, int UserId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblPishbiniInsert(fldCodingAcc_DetailsId, fldCodingBudje_DetailsId, UserId, Pishbini);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        //#region Insert
        //public int Insert(int? fldCodingAccId, int? fldCodingBudId, long fldMablagh, int fldBudgetTypeId, int? MotamamId, int userId)
        //{
        //    using (BudgetEntities p = new BudgetEntities())
        //    {
        //        var er=p.spr_tblPishbiniInsert(fldCodingAccId,fldCodingBudId, fldMablagh, fldBudgetTypeId,MotamamId, userId).FirstOrDefault();
        //            return er.fldErrorCode;
        //    }
        //}
        //#endregion
        #region Update
        public string Update(int Id, int? fldCodingAccId, int? fldCodingBudId, long fldMablagh, int fldBudgetTypeId,int? MotamamId, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblPishbiniUpdate(Id, fldCodingAccId, fldCodingBudId, fldMablagh, fldBudgetTypeId,MotamamId, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int AccCodingId,int BudgetCodingId, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblPishbiniDelete(FieldName, AccCodingId, BudgetCodingId, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}