using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_MergeFieldTypes
    {
        #region Select
        public List<OBJ_MergeFieldTypes> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblMergeFieldTypesSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_MergeFieldTypes()
                    {
                        fldDate = q.fldDate,
                        fldFaName = q.fldFaName,
                        fldId = q.fldId,
                        fldEnName = q.fldEnName,
                        fldOrganId = q.fldOrganId,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}