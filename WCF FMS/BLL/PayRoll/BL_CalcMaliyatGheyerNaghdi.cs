using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_CalcMaliyatGheyerNaghdi
    {
        DL_CalcMaliyatGheyerNaghdi CalcMaliyatGheyerNaghdi = new DL_CalcMaliyatGheyerNaghdi();
        #region Select
        public List<OBJ_CalcMaliyatGheyerNaghdi> Select(string Year, int Mablagh, int TypeEstekhdam)
        {
            return CalcMaliyatGheyerNaghdi.Select(Year, Mablagh, TypeEstekhdam);
        }
        #endregion
    }
}