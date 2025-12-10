using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.DAL.Archive
{
    public class DL_ParticularProperties
    {
        #region Detail
        public OBJ_ParticularProperties Detail(int Id)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblParticularPropertiesSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_ParticularProperties()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldArchiveTreeId = q.fldArchiveTreeId,
                        fldPropertiesId = q.fldPropertiesId,
                        fldTitle = q.fldTitle,
                        fldNameFn = q.fldNameFn
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ParticularProperties> Select(string FieldName, string FilterValue, int h)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblParticularPropertiesSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ParticularProperties()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldArchiveTreeId = q.fldArchiveTreeId,
                        fldPropertiesId = q.fldPropertiesId,
                        fldTitle = q.fldTitle,
                        fldNameFn = q.fldNameFn
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ArchiveTreeId, int PropertiesId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblParticularPropertiesInsert(ArchiveTreeId, PropertiesId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ArchiveTreeId, int PropertiesId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblParticularPropertiesUpdate(Id, ArchiveTreeId, PropertiesId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblParticularPropertiesDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (ArchiveEntities m = new ArchiveEntities())
            {
                var pro = m.spr_tblPropertiesValuesSelect("fldParticularId", Id.ToString(), 0).FirstOrDefault();
               if (pro != null)
                   q = true;
               return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ArchiveTreeId, int PropertiesId, int Id)
        {
            bool q = false;
            using (ArchiveEntities p = new ArchiveEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblParticularPropertiesSelect("fldArchiveTreeId", ArchiveTreeId.ToString(), 0).Where(l => l.fldPropertiesId == PropertiesId).Any();

                }
                else
                {
                    var query = p.spr_tblParticularPropertiesSelect("fldArchiveTreeId", ArchiveTreeId.ToString(), 0).Where(l => l.fldPropertiesId == PropertiesId).FirstOrDefault();
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