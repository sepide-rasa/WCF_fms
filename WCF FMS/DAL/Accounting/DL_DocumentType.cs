using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_DocumentType
    {
        #region Select
        public List<OBJ_DocumentType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblDocumentTypeSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_DocumentType()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}