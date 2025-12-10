using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_File
    {
        #region Select
        public List<OBJ_File> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblFileSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_File()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldImage = q.fldImage,
                        fldPasvand = q.fldPasvand
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}