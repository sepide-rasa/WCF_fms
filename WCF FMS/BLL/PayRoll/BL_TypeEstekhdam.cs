using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_TypeEstekhdam
    {
        DL_TypeEstekhdam TypeEstekhdam = new DL_TypeEstekhdam();
        #region Select
        public List<OBJ_TypeEstekhdam> Select(string FieldName, string FilterValue, int h)
        {
            return TypeEstekhdam.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}