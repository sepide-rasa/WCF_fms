using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ElamAvarez
    {
        #region Detail
        public OBJ_ElamAvarez Detail(int Id,string Value1)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblElamAvarezSelect("fldId", Id.ToString(), Value1, 1)
                    .Select(q => new OBJ_ElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAshakhasID = q.fldAshakhasID,
                        fldType = q.fldType,
                        Noe = q.Noe,
                        fldNameShakhs = q.fldNameShakhs,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldNoeShakhs=q.fldNoeShakhs,
                        fldTarikh = q.fldTarikh,
                        fldFather_Sabt = q.fldFather_Sabt,
                        fldOrganId = q.fldOrganId,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldMablaghKoli = q.fldMablaghKoli,
                        fldMablaghTakhfif = q.fldMablaghTakhfif,
                        fldMablaghGHabelPardakht = q.fldMablaghGHabelPardakht,
                        fldStatusFish = q.fldStatusFish,
                        fldStatusTakhfif = q.fldStatusTakhfif,
                        fldStatusTaghsit = q.fldStatusTaghsit,
                        fldStatusFishName = q.fldStatusFishName,
                        fldStatusTakhfifName = q.fldStatusTakhfifName,
                        fldStatusTaghsitName = q.fldStatusTaghsitName,
                        fldStatusKoli = q.fldStatusKoli,
                        fldStatusKoliName = q.fldStatusKoliName,
                        fldNameOrgan = q.fldNameOrgan,
                        SharhDesc = q.SharhDesc,
                        fldIsExternal = q.fldIsExternal,
                        fldDaramadGroupId = q.fldDaramadGroupId,
                        fldCodeSystemMabda = q.fldCodeSystemMabda,
                        fldmobile=q.fldmobile
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ElamAvarez> Select(string FieldName, string FilterValue, string Value1, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblElamAvarezSelect(FieldName, FilterValue,Value1, h)
                    .Select(q => new OBJ_ElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAshakhasID = q.fldAshakhasID,
                        fldType = q.fldType,
                        Noe = q.Noe,
                        fldNameShakhs = q.fldNameShakhs,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldNoeShakhs = q.fldNoeShakhs,
                        fldTarikh = q.fldTarikh,
                        fldFather_Sabt = q.fldFather_Sabt,
                        fldOrganId = q.fldOrganId,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldMablaghKoli = q.fldMablaghKoli,
                        fldMablaghTakhfif = q.fldMablaghTakhfif,
                        fldMablaghGHabelPardakht = q.fldMablaghGHabelPardakht,
                        fldStatusFish = q.fldStatusFish,
                        fldStatusTakhfif = q.fldStatusTakhfif,
                        fldStatusTaghsit = q.fldStatusTaghsit,
                        fldStatusFishName = q.fldStatusFishName,
                        fldStatusTakhfifName = q.fldStatusTakhfifName,
                        fldStatusTaghsitName = q.fldStatusTaghsitName,
                        fldStatusKoli = q.fldStatusKoli,
                        fldStatusKoliName = q.fldStatusKoliName,
                        fldNameOrgan = q.fldNameOrgan,
                        SharhDesc = q.SharhDesc,
                        fldIsExternal = q.fldIsExternal,
                        fldCodeSystemMabda = q.fldCodeSystemMabda,
                        fldDaramadGroupId = q.fldDaramadGroupId,
                        fldmobile = q.fldmobile
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int AshakhasID, bool Type,int OrganId,bool? IsExternal,int? DaramadGroupId,string CodeSystemMabda, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id=new System.Data.Entity.Core.Objects.ObjectParameter("fldId",typeof(int));
                p.spr_tblElamAvarezInsert(id, AshakhasID, Type, UserId, Desc, OrganId, IsExternal, DaramadGroupId, CodeSystemMabda);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int AshakhasID, bool Type, int OrganId, int? DaramadGroupId, string CodeSystemMabda, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblElamAvarezUpdate(Id, AshakhasID, Type, UserId, Desc, OrganId, DaramadGroupId, CodeSystemMabda);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblElamAvarezDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id,int state)
        {
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var q = false;
                if (state == 1)
                {
                    var Param = m.spr_tblParametreSabet_ValueSelect("fldElamAvarezId", Id.ToString(), "", 0).FirstOrDefault();
                    var c = m.spr_tblCodhayeDaramadiElamAvarezSelect("fldElamAvarezId", Id.ToString(), 0).FirstOrDefault();
                    var fish = m.spr_tblSodoorFishSelect("fldElamAvarezId", Id.ToString(), 0).FirstOrDefault();
                    var r = m.spr_tblRequestTaghsit_TakhfifSelect("fldElamAvarezId", Id.ToString(), 0).FirstOrDefault();
                    if (Param != null || fish != null || r != null || c != null)
                        q = true;
                }
                else if (state == 2)
                {
                    var fish = m.spr_tblSodoorFishSelect("fldElamAvarezId", Id.ToString(), 0).FirstOrDefault();
                    var r = m.spr_tblRequestTaghsit_TakhfifSelect("fldElamAvarezId", Id.ToString(), 0).FirstOrDefault();
                    if (fish != null || r != null)
                        q = true;
                }
                return q;
            }
        }
        #endregion
        #region DeleteWithElamAvarezId
        public string DeleteWithElamAvarezId(int ElamAvarezId,int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_DeleteWithElamAvarezId(ElamAvarezId,UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckLastIdForElamAvarez
        public List<OBJ_ElamAvarez> CheckLastIdForElamAvarez(string FieldName, int ElamAvarezId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_CheckLastIdForElamAvarez(FieldName, ElamAvarezId)
                    .Select(q => new OBJ_ElamAvarez()
                    {
                        fldType = q.fldType
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region DeleteKoliElamAvarez
        public string DeleteKoliElamAvarez(int ElamAvarezId, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_DeleteKoliElamAvarez(ElamAvarezId, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Ashkhas_ElamAvarez
        public List<OBJ_Ashkhas_ElamAvarez> Ashkhas_ElamAvarez(string FieldName, string FilterValue, int h,int AshkhasId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_SelectAshkhas_ElamAvarez(FieldName,FilterValue,h,AshkhasId)
                    .Select(q => new OBJ_Ashkhas_ElamAvarez()
                    {
                        fldId = q.fldId,
                        fldMablaghGHabelPardakht = q.fldMablaghGHabelPardakht,
                        fldMablaghKoli = q.fldMablaghKoli,
                        fldMablaghTakhfif = q.fldMablaghTakhfif,
                        fldNameOrgan = q.fldNameOrgan,
                        fldOrganId = q.fldOrganId,
                        fldTarikh = q.fldTarikh,
                        fldType = q.fldType,
                        SharhDesc = q.SharhDesc,
                        FishId = q.FishId,
                        ReplyId = q.ReplyId,
                        Noe = q.Noe,
                        fldDesc=q.fldDesc
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}