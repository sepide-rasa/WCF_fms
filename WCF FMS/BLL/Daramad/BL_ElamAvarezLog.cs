using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ElamAvarezLog
    {
        DL_ElamAvarezLog ElamAvarezLog = new DL_ElamAvarezLog();
        #region Select
        public List<OBJ_ElamAvarezLog> Select(int ElamAvarezId)
        {
            return ElamAvarezLog.Select(ElamAvarezId);
        }
        #endregion
    }
}