using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SelectDisketMaliyatForHoghogh
    {
        DL_SelectDisketMaliyatForHoghogh SelectDisketMaliyatForHoghogh = new DL_SelectDisketMaliyatForHoghogh();
        #region Select
        public List<OBJ_SelectDisketMaliyatForHoghogh> Select(short Year, byte Mah, byte Nobat, int OrganId)
        {
            return SelectDisketMaliyatForHoghogh.Select(Year, Mah, Nobat, OrganId);
        }
        #endregion
        #region SelectHoghogh_OnAccount
        public List<OBJ_SelectDisketMaliyatForHoghogh> SelectHoghogh_OnAccount(short Year, byte Mah, byte Nobat, int OrganId, byte CalcType)
        {
            return SelectDisketMaliyatForHoghogh.SelectHoghogh_OnAccount(Year, Mah, Nobat, OrganId, CalcType);
        }
        #endregion
    }
}