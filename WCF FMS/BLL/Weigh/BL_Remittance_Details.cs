using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_Remittance_Details
    {
        DL_Remittance_Details Remittance_Details = new DL_Remittance_Details();


        #region Select
        public List<OBJ_Remittance_Details> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            return Remittance_Details.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}