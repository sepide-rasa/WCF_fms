using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MaxBime
    {
        #region Select
        public List<OBJ_MaxBime> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMaxBimeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MaxBime()
                    {
                        fldId=q.fldId,
                        fldMablaghBime=q.fldMablaghBime,
                        fldYear=q.fldYear,
                       fldIp= q.fldIp,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}