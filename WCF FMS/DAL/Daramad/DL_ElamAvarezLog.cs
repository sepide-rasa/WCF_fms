using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ElamAvarezLog
    {
        #region Select
        public List<OBJ_ElamAvarezLog> Select(int ElamAvarezId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_ElamAvarelog(ElamAvarezId)
                    .Select(q => new OBJ_ElamAvarezLog()
                    {
                        Tarikh=q.fldTarikh,
                        fldUser=q.fldUser,
                        fldTypeEghdam=q.fldTypeEghdam,
                        fldtime=q.fldtime
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}