using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_ReportType
    {
        #region Select
        public List<OBJ_ReportType> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblReportTypeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ReportType()
                    {
                        fldId = q.fldId,
                        fldName = q.fldName
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}