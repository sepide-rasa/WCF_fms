using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptSanad3
    {
        #region Select
        public List<OBJ_RptSanad3> Select(short Year, byte Mah, byte Nobat, int OrganId,short CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptSanad3(Year, Mah, Nobat, OrganId, Convert.ToByte(CalcType))
                    .Select(q => new OBJ_RptSanad3()
                    {
                        ayelemandi = q.ayelemandi,
                        bime = q.bime,
                        darman = q.darman,
                        ezafekar = q.ezafekar,
                        fldEmploymentCenterId = q.fldEmploymentCenterId,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldTypeOfCostCenterId = q.fldTypeOfCostCenterId,
                        bimeKarfarma = q.bimeKarfarma,
                        darmanKarfarma = q.darmanKarfarma,
                        omrKarfarma = q.omrKarfarma,
                        pasandazKarfarma = q.pasandazKarfarma,
                        TakmiliKarfarma = q.TakmiliKarfarma,
                        tatilkari = q.tatilkari,
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
                        karane = q.karane,
                        tashilatRefahi = q.tashilatrefahi,//تو دامغان نیست شاهرود هست
                        sanavatPayanKhedmat = q.SanavatPayanKhedmat,//تو دامغان نیست شاهرود هست
                       fldMotalebat=q.fldMotalebat,
                        khoraki=q.khoraki,
                        kalaBehdashti=q.kalaBehdashti,
                        Monasebat=q.Monasebat
                      
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}