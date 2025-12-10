using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_Error
    {
        #region Select
        public List<OBJ_Error> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblErrorSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Error()
                    {
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc,
                        fldId=q.fldId,
                        fldIP=q.fldIP,
                        fldMatn=q.fldMatn,
                        fldTarikh=q.fldTarikh,
                        fldUserId=q.fldUserId,
                        fldUserName = q.fldUserName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(string UserName, string Matn, System.DateTime Tarikh, string IP, Nullable<int> UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblErrorInsert(id, UserName, Matn, Tarikh, IP, UserId, Desc);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
    }
}