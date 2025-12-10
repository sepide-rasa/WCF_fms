using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_OnAccount
    {
        DL_OnAccount OnAccount = new DL_OnAccount();
        #region Select
        public List<OBJ_OnAccount> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, string FilterValue4, int OrganId, int h)
        {
            return OnAccount.Select( FieldName,  FilterValue,  FilterValue2,  FilterValue3,  FilterValue4, OrganId ,   h);
        }
        #endregion
    }
}