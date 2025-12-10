using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_InfoPardakhtFTP
    {
        DL_InfoPardakhtFTP InfoPardakhtFTP = new DL_InfoPardakhtFTP();
        #region Select
        public List<OBJ_InfoPardakhtFTP> Select(int OrganId, string ShenaseGhabz, string ShenasePardakht)
        {
            return InfoPardakhtFTP.Select(OrganId, ShenaseGhabz, ShenasePardakht);
        }
        #endregion
    }
}