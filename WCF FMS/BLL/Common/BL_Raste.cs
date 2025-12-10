using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Raste
    {
        DL_Raste Raste = new DL_Raste();

        #region Select
        public List<OBJ_Raste> Select(string FieldName, string FilterValue, int h)
        {
            return Raste.Select(FieldName, FilterValue, h);
        }
        #endregion
        
    }
}