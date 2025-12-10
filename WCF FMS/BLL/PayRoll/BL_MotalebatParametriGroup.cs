using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MotalebatParametriGroup
    {
        DL_MotalebatParametriGroup MotalebatParametriGroup = new DL_MotalebatParametriGroup();
        #region Select
        public List<OBJ_MotalebatParametriGroup> Select(string FieldName, string FilterValue, int OrganId)
        {
            return MotalebatParametriGroup.Select(FieldName, FilterValue, OrganId);
        }
        #endregion
    }
}