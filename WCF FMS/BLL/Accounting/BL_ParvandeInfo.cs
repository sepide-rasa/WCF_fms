using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;
namespace WCF_FMS.BLL.Accounting
{
    public class BL_ParvandeInfo
    {
        DL_ParvandeInfo Parvande = new DL_ParvandeInfo();
        #region Select
        public List<OBJ_ParvandeInfo> Select(string FieldName, string FilterValue, byte ParvandeType, int OrganId, short Year, int h)
        {
            return Parvande.Select(FieldName, FilterValue, ParvandeType, OrganId,Year, h);
        }
        #endregion
    }
}