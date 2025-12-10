using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohaseleen
    {
        #region Detail
        public OBJ_Mohaseleen Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohaseleenSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_Mohaseleen
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldAfradTahtePoosheshId = q.fldAfradTahtePoosheshId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohaseleen> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblMohaseleenSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Mohaseleen()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldAfradTahtePoosheshId = q.fldAfradTahtePoosheshId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldAfradTahtePoosheshId,int fldTarikh, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohaseleenInsert(fldAfradTahtePoosheshId,fldTarikh, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldAfradTahtePoosheshId, int fldTarikh, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohaseleenUpdate(Id, fldAfradTahtePoosheshId, fldTarikh, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohaseleenDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int fldAfradTahtePoosheshId, int fldTarikh)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblMohaseleenSelect("fldAfradTahtePoosheshId", fldAfradTahtePoosheshId.ToString(), 0).Where (l=>l.fldTarikh==fldTarikh).Any();
            }
            return q;
        }
        #endregion  
    }
}