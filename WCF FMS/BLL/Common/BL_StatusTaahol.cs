using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_StatusTaahol
    {
        DL_StatusTaahol StatusTaahol = new DL_StatusTaahol();
        #region Select
        public List<OBJ_StatusTaahol> Select(string FieldName, string FilterValue, int h)
        {
            return StatusTaahol.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}