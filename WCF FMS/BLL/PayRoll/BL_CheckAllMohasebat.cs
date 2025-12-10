using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_CheckAllMohasebat
    {
        DL_CheckAllMohasebat CheckAllMohasebat = new DL_CheckAllMohasebat();
        #region Select
        public List<OBJ_CheckAllMohasebat> Select(int PersonalId)
        {
            return CheckAllMohasebat.Select(PersonalId);
        }
        #endregion
    }
}