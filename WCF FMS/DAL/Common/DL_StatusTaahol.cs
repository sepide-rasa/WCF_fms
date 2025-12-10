using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_StatusTaahol
    {
        #region Select
        public List<OBJ_StatusTaahol> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblStatusTaaholSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_StatusTaahol()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}