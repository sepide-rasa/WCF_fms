using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_BudgetType
    {
        #region Select
        public List<OBJ_BudgetType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblBudgetTypeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_BudgetType()
                    {
                        fldId = q.fldId,
                        fldTitle=q.fldTitle
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}