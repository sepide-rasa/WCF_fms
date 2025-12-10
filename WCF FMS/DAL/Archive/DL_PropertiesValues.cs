using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.DAL.Archive
{
    public class DL_PropertiesValues
    {
        #region Detail
        public OBJ_PropertiesValues Detail(int Id)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblPropertiesValuesSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PropertiesValues()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldParticularId = q.fldParticularId,
                        fldValue = q.fldValue,
                        fldNameFn = q.fldNameFn,
                        fldTitle = q.fldTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PropertiesValues> Select(string FieldName, string FilterValue, int h)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblPropertiesValuesSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PropertiesValues()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldParticularId = q.fldParticularId,
                        fldValue = q.fldValue,
                        fldNameFn = q.fldNameFn,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ParticularId, string Value, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblPropertiesValuesInsert(ParticularId, Value, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ParticularId, string Value, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblPropertiesValuesUpdate(Id, ParticularId, Value, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblPropertiesValuesDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}