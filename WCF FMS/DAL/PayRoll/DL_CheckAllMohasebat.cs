using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_CheckAllMohasebat
    {
        #region Select
        public List<OBJ_CheckAllMohasebat> Select(int PersonalId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_CheckAllMohasebat(PersonalId)
                    .Select(q => new OBJ_CheckAllMohasebat()
                    {
                        fldFlag = q.fldFlag,
                        fldPersonalId=q.fldPersonalId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}