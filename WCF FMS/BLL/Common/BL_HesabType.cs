using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_HesabType
    {
        DL_HesabType HesabType = new DL_HesabType();
        #region Select
        public List<OBJ_HesabType> Select(string FieldName, string FilterValue, int h)
        {
            return HesabType.Select(FieldName, FilterValue,  h);
        }
        #endregion
    }
}