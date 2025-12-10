using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DisketSina
    {
        DL_DisketSina DisketSina = new DL_DisketSina();
        #region Select
        public List<OBJ_DisketSina> Select(short Year, byte Mah, byte Nobat, int OrganId, int typeEstekhdam)
        {
            return DisketSina.Select(Year, Mah,  Nobat,  OrganId,  typeEstekhdam);
        }
        #endregion
        #region SelectKarmandi
        public List<OBJ_DisketSinaKarmandi> SelectKarmandi(short Year, byte Mah, byte Nobat, int OrganId, int typeEstekhdam)
        {
            return DisketSina.SelectKarmandi(Year, Mah, Nobat, OrganId, typeEstekhdam);
        }
        #endregion
    }
}