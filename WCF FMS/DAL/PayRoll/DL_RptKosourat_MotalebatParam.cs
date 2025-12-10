using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptKosourat_MotalebatParam
    {
        #region RptListAghsatVam_Excel
        public List<OBJ_RptKosourat_MotalebatParam> RptKosourat_MotalebatParam_Excel(short Year, byte Month, int ParametrId, int OrganId,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptKosourat_MotalebatParam_Excel(Year, Month, ParametrId, OrganId,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_RptKosourat_MotalebatParam()
                    {
                        fldName = q.fldName,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}