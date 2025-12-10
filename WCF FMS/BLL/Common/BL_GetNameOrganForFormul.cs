using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;


namespace WCF_FMS.BLL.Common
{
    public class BL_GetNameOrganForFormul
    {
        DL_GetNameOrganForFormul NameOrganForFormul = new DL_GetNameOrganForFormul();
        #region GetNameOrganForFormul
        public List<OBJ_GetNameOrganForFormul> GetNameOrganForFormul()
        {
            return NameOrganForFormul.GetNameOrganForFormul();
        }
        #endregion
    }
}