using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_MergeFieldTypes
    {
        DL_MergeFieldTypes MergeFieldTypes = new DL_MergeFieldTypes();

        
        #region Select
        public List<OBJ_MergeFieldTypes> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return MergeFieldTypes.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}