using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_NesbatWithPersonalInfoId
    {
        #region Select
        public List<OBJ_NesbatWithPersonalInfoId> Select(string FieldName,int PersonalId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_GetNesbatWithPersonalInfoId(FieldName,PersonalId)
                    .Select(q => new OBJ_NesbatWithPersonalInfoId()
                    {
                        Title = q.Title,
                        Value = q.Value
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}