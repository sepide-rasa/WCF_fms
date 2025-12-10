using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MaxPersonalEstekhdamType
    {
        #region Select
        public List<OBJ_MaxPersonalEstekhdamType> Select(string fieldName,int PersonalId , string tarikh)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_MaxPersonalEstekhdamType(fieldName,PersonalId,tarikh)
                    .Select(q => new OBJ_MaxPersonalEstekhdamType()
                    {
                     fldAnvaEstekhdamId=q.fldAnvaeEstekhdamId,
                     fldNoeEstekhdamId=q.fldNoeEstekhdamId,
                     fldTarikh=q.fldTarikh,
                     fldTitle=q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}