using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_NoeMasraf
    {
        #region Select
        public List<OBJ_NoeMasraf> Select(string FieldName, string FilterValue, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblNoeMasrafSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_NoeMasraf()
                    {
                        fldId = q.fldId,
                        fldName = q.fldName,
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}