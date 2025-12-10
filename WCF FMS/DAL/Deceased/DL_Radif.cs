using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Radif
    {
        #region Detail
        public OBJ_Radif Detail(int id,int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblRadifSelect("fldId", id.ToString(),0,OrganId, 1)
                    .Select(q => new OBJ_Radif
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldGheteId = q.fldGheteId,
                        fldIP = q.fldIP,
                        fldNameRadif = q.fldNameRadif,
                        fldNameGhete = q.fldNameGhete,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Radif> Select(string FieldName, string FilterValue, int Id, int OrganId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblRadifSelect(FieldName, FilterValue,Id,OrganId, h)
                    .Select(q => new OBJ_Radif()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldGheteId = q.fldGheteId,
                        fldIP = q.fldIP,
                        fldNameRadif = q.fldNameRadif,
                        fldNameGhete = q.fldNameGhete,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldGheteId, string fldNameRadif, int userId, string Desc, string IP, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblRadifInsert(fldGheteId, fldNameRadif,OrganId, userId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldGheteId, string fldNameRadif, int userId, string Desc, string IP, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblRadifUpdate(fldId, fldGheteId, fldNameRadif,OrganId, userId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblRadifDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int fldGheteId, string fldNameRadif, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblRadifSelect("CheckNameRadif", fldNameRadif,0, 0, 0).Where(l => l.fldGheteId == fldGheteId).Any();

                }
                else
                {
                    var query = p.spr_tblRadifSelect("CheckNameRadif", fldNameRadif,0, 0, 0).Where(l => l.fldGheteId == fldGheteId).FirstOrDefault();
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
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblShomareSelect("CheckRadifId", id.ToString(),0,0, 1).FirstOrDefault();
                if (m != null)
                    q = true;
            }


            return q;
        }
        #endregion
    }
}