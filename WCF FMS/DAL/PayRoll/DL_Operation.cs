using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Operation
    {
       
        #region Select
        public List<OBJ_Operation> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblOperationSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Operation()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}