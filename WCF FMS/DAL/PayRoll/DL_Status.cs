using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Status
    {
        #region Select
        public List<OBJ_Status> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblStatusSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Status()
                    {
                        fldId = q.fldId,
                        fldTitle=q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}