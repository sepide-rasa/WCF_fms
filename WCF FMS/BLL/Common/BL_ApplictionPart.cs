using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_ApplictionPart
    {
        DL_ApplictionPart ApplictionPart = new DL_ApplictionPart();
        #region Select
        public List<OBJ_ApplictionPart> Select(string FieldName, string FilterValue, string FilterValue1, int UserId, int h)
        {
            return ApplictionPart.Select(FieldName, FilterValue,FilterValue1,UserId, h);
        }
        #endregion
    }
}