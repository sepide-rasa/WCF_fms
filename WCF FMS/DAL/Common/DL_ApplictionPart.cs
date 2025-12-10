using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_ApplictionPart
    {
        #region Select
        public List<OBJ_ApplictionPart> Select(string FieldName, string FilterValue, string FilterValue1, int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblApplicationPartSelect(FieldName, FilterValue,FilterValue1,UserId, h)
                    .Select(q => new OBJ_ApplictionPart()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserID=q.fldUserID,
                        fldPID = q.fldPID,
                        fldTitle = q.fldTitle,
                        fldModuleId = q.fldModuleId
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}