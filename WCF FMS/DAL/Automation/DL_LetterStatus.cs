using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterStatus
    {
        #region Select
        public List<OBJ_LetterStatus> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterStatusSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterStatus()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldDateTime=q.fldDateTime,
                        fldUserName = q.fldUserName
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}