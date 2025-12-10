using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_NezamVazife
    {
        #region Detail
        public OBJ_NezamVazife Detail(int id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblNezamVazifeSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_NezamVazife
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_NezamVazife> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblNezamVazifeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_NezamVazife()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblNezamVazifeInsert(fldTitle, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(byte fldId, string fldTitle, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblNezamVazifeUpdate(fldId, fldTitle, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(byte id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblNezamVazifeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(byte id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_Prs_tblPersonalInfoSelect("CheckNezamVazifeId", id.ToString(), 0, 0).Any();
                return q;
            }
        }
        #endregion
    }
}