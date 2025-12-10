using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_CodingLevel
    {
        #region Detail
        public OBJ_CodingLevel Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblCodingLevelSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_CodingLevel
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldOrganId = q.fldOrganId,
                        fldFiscalBudjeId = q.fldFiscalBudjeId,
                        fldArghamNum = q.fldArghamNum,
                        fldIP = q.fldIP
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodingLevel> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblCodingLevelSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_CodingLevel()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldOrganId = q.fldOrganId,
                        fldFiscalBudjeId = q.fldFiscalBudjeId,
                        fldArghamNum = q.fldArghamNum,
                        fldIP = q.fldIP
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldFiscalBudjeId,int fldArghamNum, int OrganId, int userId, string Desc, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingLevelInsert(fldName, fldFiscalBudjeId, fldArghamNum, OrganId, Desc, userId, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldFiscalBudjeId, int fldArghamNum, int OrganId, int userId, string Desc, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingLevelUpdate(Id, fldName, fldFiscalBudjeId, fldArghamNum, OrganId, Desc, userId, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingLevelDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region BudjeLevel
        public List<OBJ_BudjeLevel> BudjeLevel(short Year, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_BudjeLevel(Year, OrganId)
                    .Select(q => new OBJ_BudjeLevel()
                    {
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldOrganId = q.fldOrganId,
                        fldArghamNum = q.fldArghamNum,
                        fldYear = q.fldYear
                    }).ToList();
                return test;
            }
        }
        #endregion
        
    }
}