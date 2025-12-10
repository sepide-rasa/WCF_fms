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
    public class DL_DetailPayeSanavati
    {
        #region Detail
        public OBJ_DetailPayeSanavati Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDetailPayeSanavatiSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_DetailPayeSanavati()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldGroh = q.fldGroh,
                        fldId = q.fldId,
                        fldMablagh = q.fldMablagh,
                        fldPayeSanavatiId = q.fldPayeSanavatiId,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DetailPayeSanavati> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDetailPayeSanavatiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DetailPayeSanavati()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldGroh = q.fldGroh,
                        fldId = q.fldId,
                        fldMablagh = q.fldMablagh,
                        fldPayeSanavatiId = q.fldPayeSanavatiId,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PayeSanavatiId, byte Groh, int Mablagh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDetailPayeSanavatiInsert(PayeSanavatiId, Groh, Mablagh, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PayeSanavatiId, byte Groh, int Mablagh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDetailPayeSanavatiUpdate(Id, PayeSanavatiId, Groh, Mablagh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDetailPayeSanavatiDelete(FieldName,Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}