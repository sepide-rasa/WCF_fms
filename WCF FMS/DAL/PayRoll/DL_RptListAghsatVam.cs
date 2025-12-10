using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptListAghsatVam
    {
        #region RptListAghsatVam_Excel
        public List<OBJ_RptListAghsatVam> RptListAghsatVam_Excel(short Year, byte Month, int OrganId,short CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptListAghsatVam_Excel(Year, Month, OrganId, Convert.ToByte(CalcType))
                    .Select(q => new OBJ_RptListAghsatVam()
                    {
                        fldName = q.fldName,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}