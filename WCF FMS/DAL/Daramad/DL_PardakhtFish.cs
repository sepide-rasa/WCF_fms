using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PardakhtFish
    {
        #region Detail
        public OBJ_PardakhtFish Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPardakhtFishSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PardakhtFish()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDatePardakht = q.fldDatePardakht,
                        fldFishId = q.fldFishId,
                        fldNahvePardakhtId = q.fldNahvePardakhtId,
                        fldTarikh = q.fldTarikh,
                        fldPardakhtFiles_DetailId = q.fldPardakhtFiles_DetailId,
                        fldDateVariz = q.fldDateVariz,
                        fldTarikhVariz = q.fldTarikhVariz
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PardakhtFish> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPardakhtFishSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PardakhtFish()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDatePardakht = q.fldDatePardakht,
                        fldFishId = q.fldFishId,
                        fldNahvePardakhtId = q.fldNahvePardakhtId,
                        fldTarikh = q.fldTarikh,
                        fldDateVariz = q.fldDateVariz,
                        fldTarikhVariz = q.fldTarikhVariz
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int FishId, System.DateTime DatePardakht, int NahvePardakhtId, Nullable<int> PardakhtFiles_DetailId,System.DateTime DateVariz, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFishInsert(FishId, DatePardakht, NahvePardakhtId, UserId, Desc, PardakhtFiles_DetailId, DateVariz);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int FishId, System.DateTime DatePardakht, int NahvePardakhtId, Nullable<int> PardakhtFiles_DetailId, System.DateTime DateVariz, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFishUpdate(Id, FishId, DatePardakht, NahvePardakhtId, UserId, Desc, PardakhtFiles_DetailId, DateVariz);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFishDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int FishId, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblPardakhtFishSelect("fldFishId", FishId.ToString(), 0).Any();

                }
                else
                {
                    var query = p.spr_tblPardakhtFishSelect("fldFishId", FishId.ToString(), 0).FirstOrDefault();
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