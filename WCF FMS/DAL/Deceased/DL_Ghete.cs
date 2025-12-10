using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Ghete
    {
        #region Detail
        public OBJ_Ghete Detail(int id, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblGheteSelect("fldId", id.ToString(),0,OrganId, 1)
                    .Select(q => new OBJ_Ghete
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldNameGhete = q.fldNameGhete,
                        fldIP = q.fldIP,
                        NameVadiSalam = q.NameVadiSalam,
                        fldorganid=q.fldorganid,
                        ExistsRecored = q.ExistsRecored,
                        CountRadif = q.CountRadif,
                        CountShomare = q.CountShomare
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Ghete> Select(string FieldName, string FilterValue,int id,int OrganId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblGheteSelect(FieldName, FilterValue,id,OrganId, h)
                    .Select(q => new OBJ_Ghete()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldNameGhete = q.fldNameGhete,
                        fldIP = q.fldIP,
                        NameVadiSalam = q.NameVadiSalam,
                        fldorganid = q.fldorganid,
                        ExistsRecored = q.ExistsRecored,
                        CountRadif = q.CountRadif,
                        CountShomare = q.CountShomare
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldVadiSalamId, string fldNameGhete,int Radif,int Shomare,string Tabaghe, int userId, string Desc, string IP,int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblGheteInsert(fldVadiSalamId,fldNameGhete,OrganId, userId, IP, Desc,Radif,Shomare,Tabaghe);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldVadiSalamId, string fldNameGhete, int userId, string Desc, string IP,int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblGheteUpdate(fldId, fldVadiSalamId, fldNameGhete,OrganId, userId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblGheteDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int fldVadiSalamId, string fldNameGhete, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblGheteSelect("CheckNameGhete", fldNameGhete,0, 0, 0).Where(l => l.fldVadiSalamId == fldVadiSalamId).Any();

                }
                else
                {
                    var query = p.spr_tblGheteSelect("CheckNameGhete", fldNameGhete,0, 0, 0).Where(l => l.fldVadiSalamId == fldVadiSalamId).FirstOrDefault();
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
                var m = p.spr_tblRadifSelect("CheckGheteId", id.ToString(),0,0, 1).FirstOrDefault();
                if (m != null)
                    q = true;
            }


            return q;
        }
        #endregion
        #region UpdateGheteKhali
        public string UpdateGheteKhali(int fldGheteId, int fldVadiSalamId, string fldNameGhete, int Radif, int Shomare, string Tabaghe, int userId, string Desc, string IP, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_UpdateGheteKhali(fldVadiSalamId, fldGheteId, fldNameGhete, OrganId, userId, IP, Desc, Radif, Shomare, Tabaghe);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region SelectGheteDetail
        public List<OBJ_Ghete> SelectGheteDetail(int GheteId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_SelectGheteDetail(GheteId)
                    .Select(q => new OBJ_Ghete()
                    {
                        Ghete = q.Ghete,
                        fldNameGhete=q.fldNameGhete,
                        CountShomare=q.CountShomare,
                        CountRadif=q.CountRadif,
                        fldId=q.fldId,
                        fldDesc=q.fldDesc,
                        fldVadiSalamId=q.fldVadiSalamId
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region DeleteAllTablesOnGhete
        public string DeleteAllTablesOnGhete(int GheteId,int UserId,string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_DeleteAllTablesOnGhete(GheteId, UserId,IP);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckDeleteAllTables
        public bool CheckDeleteAllTables(int GheteId,int Organid)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblGhabreAmanatSelect("CheckGhabrPor", GheteId.ToString(), Organid, 1).FirstOrDefault();
                var r = p.spr_tblRequestAmanatSelect("CheckGhabrPor", GheteId.ToString(), Organid, 1).FirstOrDefault();
                if (m != null || r != null)
                    q = true;
            }


            return q;
        }
        #endregion 

        #region UpdateTedadTabaghat
        public string UpdateTedadTabaghat(int fldGheteId, string fldShomare, string fldNameGhete, int userId, string Desc,int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_UpdateTedadTabaghat(fldShomare, fldGheteId, fldNameGhete, Desc,  userId,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}