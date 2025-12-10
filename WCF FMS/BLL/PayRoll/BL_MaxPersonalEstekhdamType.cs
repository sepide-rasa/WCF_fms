using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MaxPersonalEstekhdamType
    {
        DL_MaxPersonalEstekhdamType MaxPersonalEstekhdamType = new DL_MaxPersonalEstekhdamType();
        #region Select
        public List<OBJ_MaxPersonalEstekhdamType> Select(string fieldName, int PersonalId, string tarikh)
        {
            return MaxPersonalEstekhdamType.Select(fieldName,PersonalId,tarikh);
        }
        #endregion
    }
}