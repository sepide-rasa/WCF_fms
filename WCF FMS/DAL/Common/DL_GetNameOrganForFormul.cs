using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.Common
{
    public class DL_GetNameOrganForFormul
    {
        #region GetNameOrganForFormul
        public List<OBJ_GetNameOrganForFormul> GetNameOrganForFormul()
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_GetNameOrganForFormul()
                    .Select(q => new OBJ_GetNameOrganForFormul()
                    {
                        fldId = q.fldId,
                        fldName =q.fldName
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}