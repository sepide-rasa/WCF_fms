using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterStatus
    {
        DL_LetterStatus LetterStatus = new DL_LetterStatus();

        
        #region Select
        public List<OBJ_LetterStatus> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return LetterStatus.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}