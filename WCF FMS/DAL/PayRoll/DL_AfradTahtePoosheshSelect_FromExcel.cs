using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_AfradTahtePoosheshSelect_FromExcel
    {
        #region Select
        public List<OBJ_AfradTahtePoosheshSelect_FromExcel> Select(string CodeMeli,int GharardadBimeId,int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_AfradTahtePoosheshSelect_FromExcel(CodeMeli,GharardadBimeId,UserId)
                    .Select(q => new OBJ_AfradTahtePoosheshSelect_FromExcel()
                    {
                        fldCodemeli = q.fldCodemeli
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}