using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_EmalTakhfif
    {
        #region Select
        public List<OBJ_EmalTakhfif> Select(int ElamAvarezId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_SelectForEmalTakhfif(ElamAvarezId)
                    .Select(q => new OBJ_EmalTakhfif()
                    {
                        AsliValue = q.AsliValue,
                        fldDaramadCode = q.fldDaramadCode,
                        fldID = q.fldID,
                        fldSharheCodeDaramad = q.fldSharheCodeDaramad,
                        fldTakhfifAsliValue = q.fldTakhfifAsliValue,
                        fldTedad = q.fldTedad,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}