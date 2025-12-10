using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;
namespace WCF_FMS.DAL.Budget
{
    public class DL_TaahodatSanavati
    {
        #region Detail
        public OBJ_TaahodatSanavati Detail(int id)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblTahodatSanavatiSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_TaahodatSanavati
                    {
                        fldId = q.fldId,
                        fldD1=q.fldD1,
                        fldD2=q.fldD2,
                        fldD3=q.fldD3,
                        fldFiscalYearId=q.fldFiscalYearId,
                        fldH1=q.fldH1,
                        fldH2=q.fldH2,
                        fldH3=q.fldH3,
                        fldH4=q.fldH4
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TaahodatSanavati> Select(string FieldName, string FilterValue, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblTahodatSanavatiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_TaahodatSanavati()
                    {
                        fldId = q.fldId,
                        fldD1 = q.fldD1,
                        fldD2 = q.fldD2,
                        fldD3 = q.fldD3,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldH1 = q.fldH1,
                        fldH2 = q.fldH2,
                        fldH3 = q.fldH3,
                        fldH4 = q.fldH4
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(long fldD1, long fldD2, long fldD3, long fldH1, long fldH2, long fldH3, long fldH4, int fldFiscalYearId, int userId, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTahodatSanavatiInsert(fldD1,fldD2,fldD3,fldH1,fldH2,fldH3,fldH4,fldFiscalYearId,userId, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long fldD1, long fldD2, long fldD3, long fldH1, long fldH2, long fldH3, long fldH4, int userId, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTahodatSanavatiUpdate(Id, fldD1, fldD2, fldD3, fldH1, fldH2, fldH3, fldH4, userId, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}