using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.DAL.Archive
{
    public class DL_Properties
    {
        #region Detail
        public OBJ_Properties Detail(int Id)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblPropertiesSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Properties()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFormulId = q.fldFormulId,
                        fldNameEn = q.fldNameEn,
                        fldNameFn = q.fldNameFn,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Properties> Select(string FieldName, string FilterValue, int h)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblPropertiesSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Properties()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFormulId = q.fldFormulId,
                        fldNameEn = q.fldNameEn,
                        fldNameFn = q.fldNameFn,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string NameFn,string NameEn, int Type, int? FormulId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblPropertiesInsert(NameFn, NameEn, Type, FormulId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string NameFn, string NameEn, int Type, int? FormulId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblPropertiesUpdate(Id, NameFn, NameEn, Type, FormulId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblPropertiesDelete(Id, UserId);
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
               var Pa= m.spr_tblParticularPropertiesSelect("fldPropertiesId", Id.ToString(), 0).FirstOrDefault();
               if (Pa != null)
                   q = true;
            }
            return q;
        }
        #endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string NameFn, string NameEn, int Id)
        {
            bool q = false;
            using (ArchiveEntities p = new ArchiveEntities())
            {
                if (Id == 0)
                {
                    var Parametre = p.spr_tblPropertiesSelect("fldNameFn", NameFn, 0).FirstOrDefault();
                    if (Parametre != null)
                        q = true;
                    var Parametre1 = p.spr_tblPropertiesSelect("fldNameEn", NameEn, 0).FirstOrDefault();
                    if (Parametre1 != null)
                        q = true;
                }
                else
                {
                    var query = p.spr_tblPropertiesSelect("fldNameFn", NameFn, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                    var query1 = p.spr_tblPropertiesSelect("fldNameEn", NameEn, 0).FirstOrDefault();
                    if (query1 != null && query1.fldId != Id)
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