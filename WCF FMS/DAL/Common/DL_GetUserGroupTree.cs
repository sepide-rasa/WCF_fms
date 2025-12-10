using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_GetUserGroupTree
    {
        #region Select
        public List<OBJ_GetUserGroupTree> Select(int UserId,int UserLoginId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_GetUserGroupTree(UserId, UserLoginId)
                    .Select(q => new OBJ_GetUserGroupTree()
                    {
                        fldGrant = q.fldGrant,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldWithGrant = q.fldWithGrant,
                        fldUserID = q.fldUserID,
                        fldWithGrantLogin = q.fldWithGrantLogin
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}