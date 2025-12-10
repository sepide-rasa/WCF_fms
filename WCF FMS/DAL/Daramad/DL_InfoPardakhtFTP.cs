using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_InfoPardakhtFTP
    {
        #region Select
        public List<OBJ_InfoPardakhtFTP> Select(int OrganId,string ShenaseGhabz, string ShenasePardakht)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_InfoPardakhtFTP(OrganId,ShenaseGhabz,ShenasePardakht)
                    .Select(q => new OBJ_InfoPardakhtFTP()
                    {
                        fldId = q.fldId,
                        fldCodAnformatic=q.fldCodAnformatic,
                        fldCodKhedmat=q.fldCodKhedmat,
                        fldName=q.fldName,
                        fldShorooShenaseGhabz = q.fldShorooShenaseGhabz,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}