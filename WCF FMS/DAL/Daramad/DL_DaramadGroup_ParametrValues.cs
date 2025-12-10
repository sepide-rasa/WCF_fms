using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_DaramadGroup_ParametrValues
    {
        #region Detail
        public OBJ_DaramadGroup_ParametrValues Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblDaramadGroup_ParametrValuesSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_DaramadGroup_ParametrValues()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldParametrGroupDaramadId = q.fldParametrGroupDaramadId,
                        fldValue = q.fldValue,
                        fldFnName = q.fldFnName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DaramadGroup_ParametrValues> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblDaramadGroup_ParametrValuesSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DaramadGroup_ParametrValues()
                    {
                       
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldParametrGroupDaramadId = q.fldParametrGroupDaramadId,
                        fldValue = q.fldValue,
                        fldFnName=q.fldFnName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ElamAvarezId, int ParametrGroupDaramadId, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroup_ParametrValuesInsert(ElamAvarezId, ParametrGroupDaramadId, Value, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, int ParametrGroupDaramadId, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroup_ParametrValuesUpdate(Id, ElamAvarezId, ParametrGroupDaramadId, Value, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroup_ParametrValuesDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}