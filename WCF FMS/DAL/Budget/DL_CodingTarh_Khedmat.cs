using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_CodingTarh_Khedmat
    {

        #region Detail
        public OBJ_CodingTarh_Khedmat Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblCodingTarh_KhedmatSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_CodingTarh_Khedmat
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldCodingBudjeId = q.fldCodingBudjeId,
                        fldOrganId = q.fldOrganId,
                        fldEtebarTypeId = q.fldEtebarTypeId,
                        fldTypeMasrafId = q.fldTypeMasrafId,
                        fldAddress = q.fldAddress,
                        fldHoghoghiId = q.fldHoghoghiId,
                        fldHaghighiId = q.fldHaghighiId,
                        fldStartYear = q.fldStartYear,
                        fldEndYear = q.fldEndYear,
                        fldValue = q.fldValue,
                        fldPriceVahed = q.fldPriceVahed,
                        fldKolEtebar = q.fldKolEtebar,
                        fldTitleEtebar = q.fldTitleEtebar,
                        fldTitleMasraf = q.fldTitleMasraf,
                        fldIP = q.fldIP,
                        NameOperator = q.NameOperator
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodingTarh_Khedmat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblCodingTarh_KhedmatSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_CodingTarh_Khedmat()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldCodingBudjeId = q.fldCodingBudjeId,
                        fldOrganId = q.fldOrganId,
                        fldEtebarTypeId = q.fldEtebarTypeId,
                        fldTypeMasrafId = q.fldTypeMasrafId,
                        fldAddress = q.fldAddress,
                        fldHoghoghiId = q.fldHoghoghiId,
                        fldHaghighiId = q.fldHaghighiId,
                        fldStartYear = q.fldStartYear,
                        fldEndYear = q.fldEndYear,
                        fldValue = q.fldValue,
                        fldPriceVahed = q.fldPriceVahed,
                        fldKolEtebar = q.fldKolEtebar,
                        fldTitleEtebar = q.fldTitleEtebar,
                        fldTitleMasraf = q.fldTitleMasraf,
                        fldIP = q.fldIP,
                        NameOperator=q.NameOperator
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingBudjeId,int fldEtebarTypeId,int fldTypeMasrafId, int OrganId,string fldAddress,int? fldHoghoghiId,int? fldHaghighiId,short fldStartYear,
            short fldEndYear,int fldValue,long fldPriceVahed,long fldKolEtebar,int userId, string Desc,string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingTarh_KhedmatInsert(fldCodingBudjeId, fldEtebarTypeId, fldTypeMasrafId, OrganId, fldAddress, fldHoghoghiId, fldHaghighiId, fldStartYear, fldEndYear,
                    fldValue, fldPriceVahed, fldKolEtebar, userId, Desc,IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldCodingBudjeId, int fldEtebarTypeId, int fldTypeMasrafId, int OrganId, string fldAddress, int? fldHoghoghiId, int? fldHaghighiId, short fldStartYear,
            short fldEndYear, int fldValue, long fldPriceVahed, long fldKolEtebar, int userId, string Desc, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingTarh_KhedmatUpdate(Id, fldCodingBudjeId, fldEtebarTypeId, fldTypeMasrafId, OrganId, fldAddress, fldHoghoghiId, fldHaghighiId, fldStartYear, fldEndYear,
                    fldValue, fldPriceVahed, fldKolEtebar, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingTarh_KhedmatDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}