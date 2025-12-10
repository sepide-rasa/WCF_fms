using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_MasrafType
    {
        DL_MasrafType MasrafType = new DL_MasrafType();

        #region Select
        public List<OBJ_MasrafType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return MasrafType.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}