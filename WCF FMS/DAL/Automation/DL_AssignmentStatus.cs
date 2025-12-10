using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_AssignmentStatus
    {
       
        #region Select
        public List<OBJ_AssignmentStatus> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblAssignmentStatusSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_AssignmentStatus()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}