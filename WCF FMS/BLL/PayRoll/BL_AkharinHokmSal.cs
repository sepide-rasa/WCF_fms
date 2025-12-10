using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_AkharinHokmSal
    {
        DL_AkharinHokmSal AkharinHokmSal = new DL_AkharinHokmSal();
        #region Select
        public List<OBJ_AkharinHokmSal> Select(int PersonalId, string Year)
        {
            return AkharinHokmSal.Select(PersonalId, Year);
        }
        #endregion
    }
}