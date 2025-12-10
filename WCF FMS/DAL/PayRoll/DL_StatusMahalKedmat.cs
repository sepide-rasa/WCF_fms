using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_StatusMahalKedmat
    {
        #region Select
        public List<OBJ_StatusMahalKedmat> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblStatusMahalKhedmatSelect(FieldName, FilterValue,  h)
                    .Select(q => new OBJ_StatusMahalKedmat()
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