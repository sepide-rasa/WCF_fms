using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PatternFish_DaramadGroup
    {
        #region Detail
        public OBJ_PatternFish_DaramadGroup Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPatternFish_DaramadGroupSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PatternFish_DaramadGroup()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDaramadGroupId = q.fldDaramadGroupId,
                        fldPatternFishId = q.fldPatternFishId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PatternFish_DaramadGroup> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPatternFish_DaramadGroupSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PatternFish_DaramadGroup()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDaramadGroupId = q.fldDaramadGroupId,
                        fldPatternFishId = q.fldPatternFishId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PatternFishId, int DaramadGroupId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPatternFish_DaramadGroupInsert(PatternFishId, DaramadGroupId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PatternFishId, int DaramadGroupId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPatternFish_DaramadGroupUpdate(Id, PatternFishId, DaramadGroupId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPatternFish_DaramadGroupDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}