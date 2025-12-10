using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_TypeEstekhdam
    {
        #region Select
        public List<OBJ_TypeEstekhdam> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTypeEstekhdamSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_TypeEstekhdam()
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