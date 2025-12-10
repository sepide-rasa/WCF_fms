using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_GetDate
    {
        #region GetDate
        public OBJ_GetDate GetDate()
        {
            DL_GetDate GetDate = new DL_GetDate();
            return GetDate.GetDate();
        }
        #endregion
    }
}