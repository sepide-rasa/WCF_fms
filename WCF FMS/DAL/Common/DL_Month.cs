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
    public class DL_Month
    {
        #region Select
        public List<OBJ_Month> Select()
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_SelectMonth()
                    .Select(q => new OBJ_Month()
                    {
                        fldCode = q.fldCode,
                        fldName = q.fldName
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}