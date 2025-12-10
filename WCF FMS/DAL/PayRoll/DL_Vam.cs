using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Vam
    {
        #region Detail
        public OBJ_Vam Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblVamSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Vam()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodemeli = q.fldCodemeli,
                        fldCount = q.fldCount,
                        fldMablagh = q.fldMablagh,
                        fldMablaghVam = q.fldMablaghVam,
                        fldMandeVam = q.fldMandeVam,
                        fldName_Father = q.fldName_Father,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldStartDate = q.fldStartDate,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhDaryaft = q.fldTarikhDaryaft,
                        fldTypeVam = q.fldTypeVam,
                        fldTypeVamName = q.fldTypeVamName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Vam> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblVamSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Vam()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodemeli = q.fldCodemeli,
                        fldCount = q.fldCount,
                        fldMablagh = q.fldMablagh,
                        fldMablaghVam = q.fldMablaghVam,
                        fldMandeVam = q.fldMandeVam,
                        fldName_Father = q.fldName_Father,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldStartDate = q.fldStartDate,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhDaryaft = q.fldTarikhDaryaft,
                        fldTypeVam = q.fldTypeVam,
                        fldTypeVamName = q.fldTypeVamName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblVamInsert(PersonalId, TarikhDaryaft, TypeVam, MablaghVam, StartDate, Count, Mablagh, MandeVam, Status, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblVamUpdate(Id, PersonalId, TarikhDaryaft, TypeVam, MablaghVam, StartDate, Count, Mablagh, MandeVam, Status, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblVamDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblMohasebat_PersonalInfoSelect("CheckVamId", Id.ToString(), 0, 0).Any();
                return q;
            }
        }
        #endregion
        #region VamStatusUpdate
        public string VamStatusUpdate(int Id, bool Status, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblVamStatusUpdate(Id, Status, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}