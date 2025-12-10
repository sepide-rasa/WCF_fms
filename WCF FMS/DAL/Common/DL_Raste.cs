using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_Raste
    {
        #region Select
        public List<OBJ_Raste> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblRasteSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Raste()
                    {
                        
                        fldId = q.fldId,
                        fldText = q.fldText,
                        fldCode = q.fldCode,
                        fldIndex = q.fldIndex,
                        fldMaliyat = q.fldMaliyat,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}