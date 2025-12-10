using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptMaliyatSaliyane
    {
        #region RptMaliyatSaliyane
        public List<OBJ_RptMaliyatSaliyane> RptMaliyatSaliyane(int PersonId,short Year,byte Month, int OrganId,byte type,int UserId)
        {
            using (RasaFMSPayRollDBEntities  p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptMaliyatSaliyane(Year, Month, OrganId, type, UserId,PersonId)
                    .Select(q => new OBJ_RptMaliyatSaliyane()
                    {
                       
                        fldName = q.fldName,
                        fldPersonalId = q.fldPersonalId,
                        fldMablaghGheirMostamarGHeirNaghdi = q.fldMablaghGheirMostamarGHeirNaghdi,
                        fldMablaghGheirMostamarNaghdi = q.fldMablaghGheirMostamarNaghdi,
                        fldMablaghMostamarGHeirNaghdi = q.fldMablaghMostamarGHeirNaghdi,
                        fldMablaghMostamarNaghdi = q.fldMablaghMostamarNaghdi,
                        fldCodemeli = q.fldCodemeli,
                        fldMonth=q.fldMonth,
                        fldMaliyat=q.fldMaliyat,
                        fldBimePersonal=q.fldBimePersonal
                    }).ToList();
                return k;
            }
        }
        #endregion

        #region RptEkhtelafMaliyatBaDaraei
        public List<OBJ_RptEkhtelafMaliyatBaDaraei> RptEkhtelafMaliyatBaDaraei(short Year, byte Month, byte nobatPardakht, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_RptEkhtelafMaliyatBaDaraei(Year, Month,nobatPardakht, OrganId)
                    .Select(q => new OBJ_RptEkhtelafMaliyatBaDaraei()
                    {

                        fldName = q.fldName,
                        fldPersonalId = q.fldPersonalId,
                        fldCodemeli = q.fldCodemeli,
                        fldEkhtelafMaliyat = q.fldEkhtelafMaliyat,
                        fldFatherName = q.fldFatherName,
                        fldMaliyat = q.fldMaliyat,
                        fldMaliyatCalc = q.fldMaliyatCalc,
                        fldMaliyatMoavagh = q.fldMaliyatMoavagh
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}