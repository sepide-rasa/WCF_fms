using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;


namespace WCF_FMS.DAL.Weigh
{
    public class DL_ElamAvarez_ModuleOrgan
    {
        #region Select
        public List<OBJ_ElameAvarez_ModuleOrgan> Select(string FieldName, string FilterValue, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblElamAvarez_ModuleOrganSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ElameAvarez_ModuleOrgan()
                    {
                        fldCodeDaramdElamAvarezId=q.fldCodeDaramdElamAvarezId,
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc,
                        fldElamAvarezId=q.fldElamAvarezId,
                        fldId=q.fldId,
                        fldIP=q.fldIP,
                        fldModulOrganId=q.fldModulOrganId,
                        fldUserId=q.fldUserId,
                        Id=q.Id
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldElamAvarezId, int fldCodeDaramdElamAvarezId, int Id, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblElamAvarez_ModuleOrganInsert(fldElamAvarezId, fldCodeDaramdElamAvarezId, Id, userId,IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}