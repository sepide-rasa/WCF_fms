using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_MeasureUnit
    {
        #region Detail
        public OBJ_MeasureUnit Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMeasureUnitSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MeasureUnit()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldNameVahed = q.fldNameVahed
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MeasureUnit> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMeasureUnitSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MeasureUnit()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldNameVahed = q.fldNameVahed
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string NameVahed, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMeasureUnitInsert(NameVahed, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id,string NameVahed, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMeasureUnitUpdate(Id, NameVahed, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMeasureUnitDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                q = p.spr_tblCodhayeDaramdSelect("fldUnitId", id.ToString(),0,0, 0).Any();
                return q;
            }

        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string NameVahed, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMeasureUnitSelect("fldNameVahed", NameVahed, 0).Any();

                }
                else
                {
                    var query = p.spr_tblMeasureUnitSelect("fldNameVahed", NameVahed, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}