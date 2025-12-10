using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Mokatebat
    {
        #region Detail
        public OBJ_Mokatebat Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMokatebatSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Mokatebat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodhayeDaramadiElamAvarezId = q.fldCodhayeDaramadiElamAvarezId,
                        fldFileId = q.fldFileId,
                        fldSharheCodeDaramad = q.fldSharheCodeDaramad,
                        fldElamAvarezId = q.fldElamAvarezId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mokatebat> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMokatebatSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Mokatebat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodhayeDaramadiElamAvarezId = q.fldCodhayeDaramadiElamAvarezId,
                        fldFileId = q.fldFileId,
                        fldSharheCodeDaramad = q.fldSharheCodeDaramad,
                        fldElamAvarezId = q.fldElamAvarezId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int CodhayeDaramadiElamAvarezId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id=new System.Data.Entity.Core.Objects.ObjectParameter("fldId",typeof(int));
                p.spr_tblMokatebatInsert(Id, CodhayeDaramadiElamAvarezId,UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public int Update(int Id, int CodhayeDaramadiElamAvarezId, byte[] File, string Pasvand, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter FileId = new System.Data.Entity.Core.Objects.ObjectParameter("fldFileId", typeof(int));
                p.spr_tblMokatebatUpdate(Id, CodhayeDaramadiElamAvarezId, FileId, File, Pasvand, UserId, Desc);
                return Convert.ToInt32(FileId.Value);
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMokatebatDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var sh = m.spr_tblShomareNameHaSelect("fldMokatebatId", Id.ToString(), 0).FirstOrDefault();
                if (sh != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}