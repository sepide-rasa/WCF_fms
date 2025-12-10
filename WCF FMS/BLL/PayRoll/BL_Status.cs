using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Status
    {
        DL_Status Status = new DL_Status();
        #region Select
        public List<OBJ_Status> Select(string FieldName, string FilterValue, int h)
        {
            return Status.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}