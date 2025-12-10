using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_TabJobOfBime
    {
        #region Select
        public List<OBJ_TabJobOfBime> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTabJobOfBimeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_TabJobOfBime()
                    {
                        fldJobCode = q.fldJobCode,
                        fldJobDesc = q.fldJobDesc
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}