using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_SodoorFish_Detail
    {
        #region Detail
        public OBJ_SodoorFish_Detail Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblSodoorFish_DetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_SodoorFish_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodeElamAvarezId=q.fldCodeElamAvarezId,
                        fldFishId = q.fldFishId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SodoorFish_Detail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblSodoorFish_DetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_SodoorFish_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodeElamAvarezId = q.fldCodeElamAvarezId,
                        fldFishId = q.fldFishId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int FishId, int CodeElamAvarezId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblSodoorFish_DetailInsert(FishId,CodeElamAvarezId,UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int FishId, int CodeElamAvarezId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblSodoorFish_DetailUpdate(Id, FishId, CodeElamAvarezId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblSodoorFish_DetailDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int FishId, int CodeElamAvarezId, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblSodoorFish_DetailSelect("fldFishId", FishId.ToString(), 0).Where(l => l.fldCodeElamAvarezId == CodeElamAvarezId).Any();

                }
                else
                {
                    var query = p.spr_tblSodoorFish_DetailSelect("fldFishId", FishId.ToString(), 0).Where(l => l.fldCodeElamAvarezId == CodeElamAvarezId).FirstOrDefault();
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