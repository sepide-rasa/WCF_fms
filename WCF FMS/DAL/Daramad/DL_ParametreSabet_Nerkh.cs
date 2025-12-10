using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ParametreSabet_Nerkh
    {
        #region Detail
        public OBJ_ParametreSabet_Nerkh Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreSabet_NerkhSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_ParametreSabet_Nerkh()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldParametreSabetId = q.fldParametreSabetId,
                        fldTarikhFaalSazi = q.fldTarikhFaalSazi,
                        fldValue = q.fldValue,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ParametreSabet_Nerkh> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreSabet_NerkhSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ParametreSabet_Nerkh()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldParametreSabetId = q.fldParametreSabetId,
                        fldTarikhFaalSazi = q.fldTarikhFaalSazi,
                        fldValue = q.fldValue,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ParametreSabetId, string TarikhFaalSazi, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreSabet_NerkhInsert(ParametreSabetId, TarikhFaalSazi, Value, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ParametreSabetId, string TarikhFaalSazi, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreSabet_NerkhUpdate(Id, ParametreSabetId, TarikhFaalSazi, Value, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreSabet_NerkhDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}