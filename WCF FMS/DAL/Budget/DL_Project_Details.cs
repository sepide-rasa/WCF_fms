using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Project_Details
    {
        #region Detail
        public OBJ_Project_Details Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblProject_DetailsSelect("fldId", id.ToString(), OrganId,0, 1)
                    .Select(q => new OBJ_Project_Details
                    {
                        fldId = q.fldId,
                        fldDate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldAddress=q.fldAddress,
                        fldEndYear=q.fldEndYear,
                        fldEtebar=q.fldEtebar,
                        fldGheymatVahed=q.fldGheymatVahed,
                        fldMeghdar=q.fldMeghdar,
                        fldMojri=q.fldMojri,
                        fldProject_faaliyatId=q.fldProject_faaliyatId,
                        fldStratYear = q.fldStratYear,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Project_Details> Select(string FieldName, string FilterValue,short Year, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblProject_DetailsSelect(FieldName, FilterValue, OrganId,Year, h)
                    .Select(q => new OBJ_Project_Details()
                    {
                        fldId = q.fldId,
                        fldDate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldAddress = q.fldAddress,
                        fldEndYear = q.fldEndYear,
                        fldEtebar = q.fldEtebar,
                        fldGheymatVahed = q.fldGheymatVahed,
                        fldMeghdar = q.fldMeghdar,
                        fldMojri = q.fldMojri,
                        fldProject_faaliyatId = q.fldProject_faaliyatId,
                        fldStratYear = q.fldStratYear,
                        fldYear = q.fldYear
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int Project_faaliyatId, string Address, string Mojri, short StratYear, short EndYear, int Meghdar, long GheymatVahed, long Etebar, short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblProject_DetailsInsert(Project_faaliyatId, Address, Mojri,Year, StratYear, EndYear, Meghdar, GheymatVahed, Etebar, OrganId, Desc, userId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int Project_faaliyatId, string Address, string Mojri, short StratYear, short EndYear, int Meghdar, long GheymatVahed, long Etebar, short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblProject_DetailsUpdate(Id, Project_faaliyatId, Address, Mojri,Year, StratYear, EndYear, Meghdar, GheymatVahed, Etebar, OrganId, Desc, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblProject_DetailsDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}