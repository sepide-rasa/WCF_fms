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
    public class DL_DetailHoghoghMabna
    {
        #region Detail
        public OBJ_DetailHoghoghMabna Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDetailHoghoghMabnaSelect("fldId", Id.ToString(), false, 1)
                    .Select(q => new OBJ_DetailHoghoghMabna()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldGroh = q.fldGroh,
                        fldHoghoghMabnaId = q.fldHoghoghMabnaId,
                        fldId = q.fldId,
                        fldMablagh = q.fldMablagh,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DetailHoghoghMabna> Select(string FieldName, string FilterValue,bool Type, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDetailHoghoghMabnaSelect(FieldName, FilterValue, Type, h)
                    .Select(q => new OBJ_DetailHoghoghMabna()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldGroh = q.fldGroh,
                        fldHoghoghMabnaId = q.fldHoghoghMabnaId,
                        fldId = q.fldId,
                        fldMablagh = q.fldMablagh,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int HoghoghMabnaId, byte Groh,int Mablagh, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDetailHoghoghMabnaInsert(HoghoghMabnaId, Groh, Mablagh, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int HoghoghMabnaId, byte Groh, int Mablagh, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDetailHoghoghMabnaUpdate(Id, HoghoghMabnaId, Groh, Mablagh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDetailHoghoghMabnaDelete(FieldName,Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}