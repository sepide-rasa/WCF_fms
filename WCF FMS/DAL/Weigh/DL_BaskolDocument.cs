using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_BaskolDocument
    {
        #region Select
        public List<OBJ_BaskolDocument> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblBaskolDocumentSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_BaskolDocument()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTozinId = q.fldTozinId,
                        fldIP = q.fldIP,
                        fldFileId = q.fldFileId,
                        fldOrganId = q.fldOrganId,
                        fldPasvand = q.fldPasvand,

                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}