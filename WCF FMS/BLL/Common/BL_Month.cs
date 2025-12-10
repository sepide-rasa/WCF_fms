using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Month
    {
        DL_Month Month = new DL_Month();
        #region Select
        public List<OBJ_Month> Select()
        {
            return Month.Select();
        }
        #endregion
    }
}