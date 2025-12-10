using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_BudgetType
    {
        DL_BudgetType BudgetType = new DL_BudgetType();

        #region Select
        public List<OBJ_BudgetType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return BudgetType.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}