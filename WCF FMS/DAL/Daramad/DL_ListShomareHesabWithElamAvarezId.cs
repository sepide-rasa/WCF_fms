using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ListShomareHesabWithElamAvarezId
    {
        #region Select
        public List<OBJ_ShomareHesabWithElamAvarezId> Select(string FieldName, string FilterValue)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_ListShomareHesabWithElamAvarezId(FieldName, FilterValue)
                    .Select(q => new OBJ_ShomareHesabWithElamAvarezId()
                    {
                        fldShomareHesab = q.fldShomareHesab,
                        fldID = q.fldID,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}