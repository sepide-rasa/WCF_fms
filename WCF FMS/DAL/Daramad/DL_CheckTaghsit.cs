using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    
    public class DL_CheckTaghsit
    {
        #region checkTaghsit
        public List<OBJ_CheckTaghsit> checkTaghsit(int ElamAvarezId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_checkTaghsit(ElamAvarezId)
                    .Select(q => new OBJ_CheckTaghsit()
                    {
                        Barat = q.Barat,
                        check = q.check,
                        fish = q.fish,
                        Safte = q.Safte
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Delete
        public string Delete(int ElamAvarezId, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_DeleteTaghsit(ElamAvarezId, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}