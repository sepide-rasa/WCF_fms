using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Common
{
    public class DL_CheckEmail
    {
        #region CheckEmail
        public OBJ_CheckEmail CheckEmail(string Email)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_CheckEmail(Email)
                    .Select(q => new OBJ_CheckEmail()
                    {
                        fldType = q.fldType
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
    }
}