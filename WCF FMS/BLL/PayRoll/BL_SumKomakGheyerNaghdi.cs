using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SumKomakGheyerNaghdi
    {
        DL_SumKomakGheyerNaghdi SumKomakGheyerNaghdi = new DL_SumKomakGheyerNaghdi();
        #region Select
        public List<OBJ_SumKomakGheyerNaghdi> Select(int PersonalId, bool Type, byte Mah, short Year)
        {
            return SumKomakGheyerNaghdi.Select(PersonalId, Type, Mah, Year);
        }
        #endregion
    }
}