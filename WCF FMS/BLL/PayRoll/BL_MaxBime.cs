using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MaxBime
    {
        DL_MaxBime MaxBime = new DL_MaxBime();
        #region Select
        public List<OBJ_MaxBime> Select(string FieldName, string FilterValue, int h)
        {
            return MaxBime.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}