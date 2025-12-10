using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_CodeDaramdAsli
    {
        public List<OBJ_ShomareHesabCodeDaramad> select()
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_CodeDaramdAsli().Select(q => new OBJ_ShomareHesabCodeDaramad()
                    {
                        fldDaramadCode=q.fldDaramadCode,
                        fldCodeDaramadId = q.fldCodeDaramadId,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldMashmooleArzesheAfzoode=q.fldMashmooleArzesheAfzoode,
                        fldMashmooleKarmozd=q.fldMashmooleKarmozd,
                        fldNameVahed=q.fldNameVahed,
                    }).ToList();
                return k;

            }
        }
    }
}