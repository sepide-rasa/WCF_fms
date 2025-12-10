using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptSanad2
    {
        #region Select
        public List<OBJ_RptSanad2> Select(short Year, byte Mah, byte Nobat, int OrganId,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptSanad2(Year, Mah, Nobat, OrganId,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_RptSanad2()
                    {
                        ayelemandi = q.ayelemandi,
                        bime = q.bime,
                        darman = q.darman,
                        ezafekar = q.ezafekar,
                        fldEmploymentCenterId = q.fldEmploymentCenterId,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldTypeOfCostCenterId = q.fldTypeOfCostCenterId,
                        haghbime = q.haghbime,
                        hoghogh = q.hoghogh,
                        Khales = q.Khales,
                        kolkosurat = q.kolkosurat,
                        KolMotalebat = q.KolMotalebat,
                        maliat = q.maliat,
                        mamoriat = q.mamoriat,
                        NameEmploymentCenter = q.NameEmploymentCenter,
                        NameTypeCostCenters = q.NameTypeCostCenters,
                        omr = q.omr,
                        pasandaz = q.pasandaz,
                        takmili = q.takmili,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}