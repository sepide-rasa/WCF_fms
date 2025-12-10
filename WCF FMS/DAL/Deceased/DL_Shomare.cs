using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Shomare
    {
        #region Detail
        public OBJ_Shomare Detail(int id, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblShomareSelect("fldId",id.ToString(),0,OrganId, 1)
                    .Select(q => new OBJ_Shomare
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldRadifId = q.fldRadifId,
                        fldIP = q.fldIp,
                        fldShomare = q.fldShomare,
                        fldTedadTabaghat = q.fldTedadTabaghat,
                        fldNameRadif = q.fldNameRadif,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Shomare> Select(string FieldName, string FilterValue,int Id, int OrganId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblShomareSelect(FieldName, FilterValue,Id,OrganId, h)
                    .Select(q => new OBJ_Shomare()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldRadifId = q.fldRadifId,
                        fldIP = q.fldIp,
                        fldShomare = q.fldShomare,
                        fldTedadTabaghat = q.fldTedadTabaghat,
                        fldNameRadif = q.fldNameRadif,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldRadifId, string fldShomare, byte fldTedadTabaghat, int userId, string Desc, string IP, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblShomareInsert(fldRadifId, fldShomare, fldTedadTabaghat,OrganId, userId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldRadifId, string fldShomare, byte fldTedadTabaghat, int userId, string Desc, string IP, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblShomareUpdate(fldId, fldRadifId, fldShomare, fldTedadTabaghat,OrganId, userId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblShomareDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int fldRadifId, string fldShomare, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblShomareSelect("ChekhShomare", fldShomare,0, 0, 0).Where(l => l.fldRadifId == fldRadifId).Any();

                }
                else
                {
                    var query = p.spr_tblShomareSelect("ChekhShomare", fldShomare,0, 0, 0).Where(l => l.fldRadifId == fldRadifId).FirstOrDefault();
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
                var m = p.spr_tblGhabreAmanatSelect("checkShomareId", id.ToString(), 0, 1).FirstOrDefault();
                var r = p.spr_tblRequestAmanatSelect("CheckShomareId", id.ToString(), 0, 0).FirstOrDefault();
                if (m != null)
                    q = true;
            }


            return q;
        }
        #endregion

        #region SelectTabaghe
        public List<OBJ_Tabaghe> SelectTabaghe(int ShomareId,int Id)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_selectTabaghe(ShomareId,Id)
                    .Select(q => new OBJ_Tabaghe()
                    {
                        Tabaghe = q.Tabaghe,
                        ShomareTabaghe = q.ShomareTabaghe
                    }).ToList();
                return test;
            }
        }
        #endregion

        
    }
}