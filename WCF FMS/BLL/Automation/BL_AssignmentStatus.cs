using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_AssignmentStatus
    {
        DL_AssignmentStatus AssignmentStatus = new DL_AssignmentStatus();

        
        #region Select
        public List<OBJ_AssignmentStatus> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return AssignmentStatus.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}