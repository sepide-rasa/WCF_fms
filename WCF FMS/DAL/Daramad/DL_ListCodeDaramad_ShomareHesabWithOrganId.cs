using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ListCodeDaramad_ShomareHesabWithOrganId
    {
        #region Select
        public List<OBJ_ListCodeDaramad_ShomareHesabWithOrganId> Select(int OrganId, byte Type, int FiscalYearId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_ListCodeDaramad_ShomareHesabWithOrganId(OrganId,Type,FiscalYearId)
                    .Select(q => new OBJ_ListCodeDaramad_ShomareHesabWithOrganId()
                    {
                        fldId = q.fldId,
                        fldDaramadCode = q.fldDaramadCode,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldMashmooleArzesheAfzoode = q.fldMashmooleArzesheAfzoode,
                        fldMashmooleKarmozd = q.fldMashmooleKarmozd,
                        fldNameVahed = q.fldNameVahed,
                        fldShomareHesab = q.fldShomareHesab,
                        fldshomarehesabId = q.fldShomareHesabId,
                        fldShomareHsabCodeDaramadId = q.fldShomareHsabCodeDaramadId,
                        fldDesc = q.fldDesc,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldStatus = q.fldStatus
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}