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
    public class DL_Signers
    {
        #region Select
        public List<OBJ_Signers> Select(int Module_OrganId, string Tarikh, int reportId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_Signers(Module_OrganId, Tarikh, reportId)
                    .Select(q => new OBJ_Signers()
                    {
                        orderId = q.orderId,
                        Post = q.Post,
                        SignerName = q.SignerName,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}