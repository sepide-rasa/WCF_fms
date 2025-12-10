using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptKosourat_MotalebatParam
    {
        DL_RptKosourat_MotalebatParam RptKosourat_MotalebatParam = new DL_RptKosourat_MotalebatParam();

        #region RptListAghsatVam_Excel
        public List<OBJ_RptKosourat_MotalebatParam> RptKosourat_MotalebatParam_Excel(short Year, byte Month, int ParametrId, int OrganId, byte CalcType)
        {
            return RptKosourat_MotalebatParam.RptKosourat_MotalebatParam_Excel(Year, Month, ParametrId, OrganId, CalcType);
        }
        #endregion
    }
}