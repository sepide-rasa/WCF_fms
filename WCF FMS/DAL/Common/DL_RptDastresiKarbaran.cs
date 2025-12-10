using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.Common
{
    public class DL_RptDastresiKarbaran
    {
        #region Select
        public List<OBJ_RptDastresiKarbaran> Select(int? appId, int? userGroup_ModuleOrganID)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_RptDastresiKarbaran(appId, userGroup_ModuleOrganID).Select(q => new OBJ_RptDastresiKarbaran()
                    {
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        NameGroupUser=q.NameGroupUser

                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}