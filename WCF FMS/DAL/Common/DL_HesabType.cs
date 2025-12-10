using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_HesabType
    {
        #region Select
        public List<OBJ_HesabType> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHesabTypeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_HesabType()
                    {
                        fldTitle = q.fldTitle,
                        fldType = q.fldType,
                        fldId = q.fldId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}