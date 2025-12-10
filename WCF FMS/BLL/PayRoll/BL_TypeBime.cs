using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_TypeBime
    {
        DL_TypeBime TypeBime = new DL_TypeBime();
        #region Select
        public List<OBJ_TypeBime> Select(string FieldName, string FilterValue, int h)
        {
            return TypeBime.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}