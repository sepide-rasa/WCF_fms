using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_ListNoMaliyat_BimePersonal
    {
        #region Select
        public List<OBJ_ListNoMaliyat_BimePersonal> Select(string FieldName, int PersonelId, short sal, byte mah, byte nobatPardakht, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_payListNoMaliyat_BimePersonal(FieldName, sal, mah, nobatPardakht, OrganId, PersonelId)
                    .Select(q => new OBJ_ListNoMaliyat_BimePersonal()
                    {
                        bime = q.bime,
                        NoeEstekhdam = q.NoeEstekhdam
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}