using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_CheckKosorat_Motalebat
    {
        #region Select
        public List<OBJ_CheckKosorat_Motalebat> Select(string FieldName,  int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_CheckKosorat_Motalebat(FieldName, id)
                    .Select(q => new OBJ_CheckKosorat_Motalebat()
                    {
                        fldType = q.fldType
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}