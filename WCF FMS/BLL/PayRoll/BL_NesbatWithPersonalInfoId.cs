using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_NesbatWithPersonalInfoId
    {
        DL_NesbatWithPersonalInfoId NesbatWithPersonalInfoId = new DL_NesbatWithPersonalInfoId();
        #region Select
        public List<OBJ_NesbatWithPersonalInfoId> Select(string FieldName, int PersonalId)
        {
            return NesbatWithPersonalInfoId.Select( FieldName,PersonalId);
        }
        #endregion
    }
}