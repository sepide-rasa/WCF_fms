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
    public class DL_HoghoghMabna
    {
        #region Detail
        public OBJ_HoghoghMabna Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHoghoghMabnaSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_HoghoghMabna()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_HoghoghMabna> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHoghoghMabnaSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_HoghoghMabna()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int Year, bool Type, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblHoghoghMabnaInsert(Id,Year, Type, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int Year, bool Type, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHoghoghMabnaUpdate(Id, Year, Type, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHoghoghMabnaDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var q = false;
                var H = p.spr_tblDetailHoghoghMabnaSelect("fldHoghoghMabnaId", Id.ToString(), false, 1).FirstOrDefault();
                if (H != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}