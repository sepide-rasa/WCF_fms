using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ParametreOmoomi
    {
        #region Detail
        public OBJ_ParametreOmoomi Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreOmoomiSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_ParametreOmoomi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldNameParametreEn = q.fldNameParametreEn,
                        fldNameParametreFa = q.fldNameParametreFa,
                        fldNoeField = q.fldNoeField,
                        NoeFieldName = q.NoeFieldName,
                        fldFormulId = q.fldFormulId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ParametreOmoomi> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreOmoomiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ParametreOmoomi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldNameParametreEn = q.fldNameParametreEn,
                        fldNameParametreFa = q.fldNameParametreFa,
                        fldNoeField = q.fldNoeField,
                        NoeFieldName = q.NoeFieldName,
                        fldFormulId = q.fldFormulId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string NameParametreFa, string NameParametreEn, byte NoeField, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreOmoomiInsert(NameParametreFa, NameParametreEn, NoeField, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string NameParametreFa, string NameParametreEn, byte NoeField, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreOmoomiUpdate(Id, NameParametreFa, NameParametreEn, NoeField, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreOmoomiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string NameParametreEn, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblParametreOmoomiSelect("fldNameParametreEn", NameParametreEn, 0).Any();

                }
                else
                {
                    var query = p.spr_tblParametreOmoomiSelect("fldNameParametreEn", NameParametreEn, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                q = p.spr_tblParametreOmoomi_ValueSelect("fldParametreOmoomiId", id.ToString(),"", 0).Any();
                return q;
            }

        }
        #endregion
    }
}