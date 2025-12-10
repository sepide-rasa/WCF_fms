using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_BudgetPayDetail
    {
        #region Detail
        public OBJ_BudgetPayDetail Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblBudgetPayDetailSelect("fldId", Id.ToString(),1)
                    .Select(q => new OBJ_BudgetPayDetail()
                    {
                        
                        fldId = q.fldId,
                        fldHeaderId = q.fldHeaderId,
                        fldTitleBime = q.fldTitleBime,
                        fldTitleEstekhdam = q.fldTitleEstekhdam,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_BudgetPayDetail> Select(string FieldName, string FilterValue,   int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblBudgetPayDetailSelect(FieldName, FilterValue,  h)
                    .Select(q => new OBJ_BudgetPayDetail()
                    {
                        fldId = q.fldId,
                        fldHeaderId = q.fldHeaderId,
                        fldTitleBime = q.fldTitleBime,
                        fldTitleEstekhdam = q.fldTitleEstekhdam,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldHeaderId ,string TypeEstekhdamId ,int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblBudgetPayDetailInsert(fldHeaderId, TypeEstekhdamId, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId ,int fldHeaderId ,int fldTypeEstekhdamId ,int fldTypeBimeId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblBudgetPayDetailUpdate( fldId,fldHeaderId , fldTypeEstekhdamId , fldTypeBimeId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region Delete
        public string Delete(int HeaderId, int TypeEstekhdamId,int TypeBimeId, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblBudgetPayDetailDelete(HeaderId, TypeEstekhdamId, TypeBimeId,UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}