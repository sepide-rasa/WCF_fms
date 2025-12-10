using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Signers
    {
        DL_Signers Signers = new DL_Signers();
        #region Select
        public List<OBJ_Signers> Select(int Module_OrganId, string Tarikh, int reportId)
        {
            return Signers.Select(Module_OrganId, Tarikh, reportId);
        }
        #endregion
    }
}