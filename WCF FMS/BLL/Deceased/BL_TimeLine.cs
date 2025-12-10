using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_TimeLine
    {
        DL_TimeLine TimeLine = new DL_TimeLine();

      
        #region Select
        public List<OBJ_TimeLine> Select(int RequestId)
        {
            return TimeLine.Select(RequestId);
        }
        #endregion
    }
}