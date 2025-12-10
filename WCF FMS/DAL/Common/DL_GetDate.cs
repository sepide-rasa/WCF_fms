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
    public class DL_GetDate
    {
        #region GetDate
        public OBJ_GetDate GetDate()
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_GetDate()
                    .Select(q => new OBJ_GetDate()
                    {
                        fldDateTime=q.fldDateTime,
                        fldTarikh=q.fldTarikh,
                        fldTime=q.fldTime
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
    }
}