using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.PayRoll;


namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Rpt12Mahe
    {
        DL_Rpt12Mahe Rpt12Mahe = new DL_Rpt12Mahe();
        #region Select
        public List<OBJ_Rpt12Mahe> Select(short Year, byte NobatPardakht, int OrganId, byte CalcType)
        {
            return Rpt12Mahe.Select(Year,  NobatPardakht, OrganId, CalcType);
        }
        #endregion
    }
}