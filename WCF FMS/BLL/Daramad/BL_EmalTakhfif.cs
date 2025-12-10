using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_EmalTakhfif
    {
        DL_EmalTakhfif EmalTakhfif = new DL_EmalTakhfif();
        #region Select
        public List<OBJ_EmalTakhfif> Select(int ElamAvarezId)
        {
            return EmalTakhfif.Select(ElamAvarezId);
        }
        #endregion
    }
}