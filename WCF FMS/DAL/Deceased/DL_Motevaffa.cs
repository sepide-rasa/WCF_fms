using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Motevaffa
    {
        #region Detail
        public OBJ_Motevaffa Detail(int id, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblMotevaffaSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Motevaffa
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldCauseOfDeathId = q.fldCauseOfDeathId,
                        fldGhabreAmanatId = q.fldGhabreAmanatId,
                        fldIP = q.fldIP,
                        fldTarikhFot = q.fldTarikhFot,
                        fldTarikhDafn = q.fldTarikhDafn,
                        fldOrganId = q.fldOrganId,
                        fldMahalFotId = q.fldMahalFotId,
                        fldNameMahal = q.fldNameMahal,
                        fldReason = q.fldReason,
                        fldname = q.fldname,
                        fldFamily = q.fldFamily,
                        fldShomare = q.fldShomare,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldGheteId = q.fldGheteId,
                        fldRadifId = q.fldRadifId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldNameVadiSalam = q.fldNameVadiSalam,
                        fldNameGhete = q.fldNameGhete,
                        fldNameRadif = q.fldNameRadif,
                        fldShomareTabaghe = q.fldTabaghe,
                        fldTypeNameMotevafa = q.fldTypeNameMotevafa,
                        fldTypeMotevafa = q.fldTypeMotevafa,
                        fldShomareId = q.fldShomareId,
                        fldCodeMotevafa = q.fldCodeMotevafa
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Motevaffa> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblMotevaffaSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Motevaffa()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldCauseOfDeathId = q.fldCauseOfDeathId,
                        fldGhabreAmanatId = q.fldGhabreAmanatId,
                        fldIP = q.fldIP,
                        fldTarikhFot = q.fldTarikhFot,
                        fldTarikhDafn = q.fldTarikhDafn,
                        fldOrganId = q.fldOrganId,
                        fldMahalFotId = q.fldMahalFotId,
                        fldNameMahal = q.fldNameMahal,
                        fldReason = q.fldReason,
                        fldname = q.fldname,
                        fldFamily = q.fldFamily,
                        fldShomare = q.fldShomare,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldGheteId = q.fldGheteId,
                        fldRadifId = q.fldRadifId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldNameVadiSalam = q.fldNameVadiSalam,
                        fldNameGhete = q.fldNameGhete,
                        fldNameRadif = q.fldNameRadif,
                        fldShomareTabaghe = q.fldTabaghe,
                        fldTypeNameMotevafa = q.fldTypeNameMotevafa,
                        fldTypeMotevafa = q.fldTypeMotevafa,
                        fldShomareId = q.fldShomareId,
                        fldCodeMotevafa = q.fldCodeMotevafa
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int? ShomareId,int? EmployeeId,int? fldCauseOfDeathId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, int userId, string Desc, string IP, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                int? TarikhFot = null;
                if (fldTarikhFot != null)
                    TarikhFot = Convert.ToInt32(fldTarikhFot.Replace("/", ""));

                int? TarikhDafn = null;
                if (fldTarikhDafn != null)
                    TarikhDafn = Convert.ToInt32(fldTarikhDafn.Replace("/", ""));
                p.spr_tblMotevaffaInsert(ShomareId,EmployeeId,fldCauseOfDeathId,TarikhFot,TarikhDafn,fldMahalFotId, OrganId, userId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int? fldCauseOfDeathId, int? fldGhabreAmanatId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, int userId, string Desc, string IP, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                int? TarikhFot = null;
                if (fldTarikhFot != null)
                    TarikhFot = Convert.ToInt32(fldTarikhFot.Replace("/", ""));

                int? TarikhDafn = null;
                if (fldTarikhDafn != null)
                    TarikhDafn = Convert.ToInt32(fldTarikhDafn.Replace("/", ""));

                p.spr_tblMotevaffaUpdate(fldId, fldCauseOfDeathId, fldGhabreAmanatId, TarikhFot, TarikhDafn, fldMahalFotId, OrganId, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblMotevaffaDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}