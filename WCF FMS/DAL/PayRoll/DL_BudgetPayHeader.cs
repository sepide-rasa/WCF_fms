using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_BudgetPayHeader
    {
        #region Detail
        public OBJ_BudgetPayHeader Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblBudgetPayHeaderSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_BudgetPayHeader()
                    {

                        fldId = q.fldId,
                        fldBudgetCode = q.fldBudgetCode,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldIP = q.fldIP,
                        fldItemsHoghughiId=q.fldItemsHoghughiId,
                        fldParametrId=q.fldParametrId,
                        fldTitle=q.fldTitle,
                        fldTitleBudget=q.fldTitleBudget,
                        fldUserId=q.fldUserId,
                        fldYear=q.fldYear,
                        fldTitleBime=q.fldTitleBime,
                        fldTitleEstkhdam=q.fldTitleEstkhdam,
                        fldTypeBimeId=q.fldTypeBimeId,
                        fldTypeEstekhdamId=q.fldTypeEstekhdamId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_BudgetPayHeader> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblBudgetPayHeaderSelect(FieldName, FilterValue,FilterValue2, h)
                    .Select(q => new OBJ_BudgetPayHeader()
                    {
                        fldId = q.fldId,
                        fldBudgetCode = q.fldBudgetCode,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldIP = q.fldIP,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldParametrId = q.fldParametrId,
                        fldTitle = q.fldTitle,
                        fldTitleBudget = q.fldTitleBudget,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                        fldTitleBime = q.fldTitleBime,
                        fldTitleEstkhdam = q.fldTitleEstkhdam,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldkosuratBudgetPayId=q.fldkosuratBudgetPayId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId, int? fldKosouratId,int fldBudgetCode, int fldUserId, string fldIP, string fldDesc, string fldTypeEstekhdamId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblBudgetPayHeaderInsert(fldFiscalYearId, fldItemsHoghughiId, fldParametrId, fldKosouratId,fldBudgetCode, fldUserId, fldIP, fldDesc, fldTypeEstekhdamId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId,int? fldKosouratId, int fldBudgetCode, int fldUserId, string fldIP, string fldDesc, string fldTypeEstekhdamId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblBudgetPayHeaderUpdate(fldId, fldFiscalYearId, fldItemsHoghughiId, fldParametrId, fldKosouratId,fldBudgetCode, fldUserId, fldIP, fldDesc, fldTypeEstekhdamId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region Delete
        public string Delete(string FieldName,int ItemId,int FiscalYearId, int fldUserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblBudgetPayHeaderDelete(FieldName, ItemId,FiscalYearId, fldUserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}