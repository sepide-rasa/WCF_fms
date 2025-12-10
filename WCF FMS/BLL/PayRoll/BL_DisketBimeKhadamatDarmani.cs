using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DisketBimeKhadamatDarmani
    {
        DL_DisketBimeKhadamatDarmani DisketBimeKhadamatDarmani = new DL_DisketBimeKhadamatDarmani();
        #region Select
        public List<OBJ_DisketBimeKhadamatDarmani> Select(short Sal, byte mah, byte nobat, int OrganId)
        {
            return DisketBimeKhadamatDarmani.Select(Sal, mah, nobat,OrganId);
        }
        #endregion
    }
}