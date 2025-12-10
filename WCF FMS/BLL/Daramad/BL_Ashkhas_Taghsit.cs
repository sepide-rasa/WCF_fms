using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Ashkhas_Taghsit
    {
        DL_Ashkhas_Taghsit Ashkhas_Taghsit = new DL_Ashkhas_Taghsit();
        #region Select
        public List<OBJ_Ashkhas_Taghsit> Select(int ElamAvarezId)
        {
            return Ashkhas_Taghsit.Select(ElamAvarezId);
        }
        #endregion
    }
}