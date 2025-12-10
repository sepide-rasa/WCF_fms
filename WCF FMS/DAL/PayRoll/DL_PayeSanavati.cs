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
    public class DL_PayeSanavati
    {
        #region Detail
        public OBJ_PayeSanavati Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblPayeSanavatiSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PayeSanavati()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PayeSanavati> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblPayeSanavatiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PayeSanavati()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int Year, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblPayeSanavatiInsert(Id,Year, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int Year, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblPayeSanavatiUpdate(Id, Year, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblPayeSanavatiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblDetailPayeSanavatiSelect("fldPayeSanavatiId", Id.ToString(), 0).Any();
                return q;
            }
        }
        #endregion
    }
}