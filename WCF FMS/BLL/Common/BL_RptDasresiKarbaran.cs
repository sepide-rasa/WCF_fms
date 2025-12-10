using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_RptDasresiKarbaran
    {
        DL_RptDastresiKarbaran RptDastresiKarbaran = new DL_RptDastresiKarbaran();
        #region Select
        public List<OBJ_RptDastresiKarbaran> Select(int? appId,int? userGroup_ModuleOrganID)

        {
            return RptDastresiKarbaran.Select(appId, userGroup_ModuleOrganID);
        }
#endregion 
    }
}