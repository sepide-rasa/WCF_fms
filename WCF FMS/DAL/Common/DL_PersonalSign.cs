using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.Common
{
    public class DL_PersonalSign
    { 
        #region Select
        public List<OBJ_PersonalSign> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblPersonalSignSelect(FieldName, FilterValue,  h)
                    .Select(q => new OBJ_PersonalSign()
                    {
                        fldId = q.fldId,
                        fldFileId = q.fldFileId,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldCommitionId = q.fldCommitionId,
                        fldIsEdit=q.fldIsEdit
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int CommitionId, byte[] FileEmza, string Passvand, int UserId, string Desc, string IP)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblPersonalSignInsert(CommitionId, FileEmza, Passvand, UserId, Desc, IP);
                
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}