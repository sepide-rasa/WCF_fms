using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Takhfif
    {
        #region Detail
        public OBJ_Takhfif Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblTakhfifSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Takhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAzTarikh = q.fldAzTarikh,
                        fldShomareMojavez = q.fldShomareMojavez,
                        fldTakhfifKoli = q.fldTakhfifKoli,
                        fldTakhfifNaghdi = q.fldTakhfifNaghdi,
                        fldTarikhMojavez = q.fldTarikhMojavez,
                        fldTaTarikh = q.fldTaTarikh,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Takhfif> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblTakhfifSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Takhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAzTarikh = q.fldAzTarikh,
                        fldShomareMojavez = q.fldShomareMojavez,
                        fldTakhfifKoli = q.fldTakhfifKoli,
                        fldTakhfifNaghdi = q.fldTakhfifNaghdi,
                        fldTarikhMojavez = q.fldTarikhMojavez,
                        fldTaTarikh = q.fldTaTarikh,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(string ShomareMojavez, string TarikhMojavez, string AzTarikh, string TaTarikh, decimal? TakhfifKoli, decimal? TakhfifNaghdi, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblTakhfifInsert(id, ShomareMojavez, TarikhMojavez, AzTarikh, TaTarikh, TakhfifKoli, TakhfifNaghdi, UserId, Desc);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string ShomareMojavez, string TarikhMojavez, string AzTarikh, string TaTarikh, decimal? TakhfifKoli, decimal? TakhfifNaghdi, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTakhfifUpdate(Id, ShomareMojavez, TarikhMojavez, AzTarikh, TaTarikh, TakhfifKoli, TakhfifNaghdi, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTakhfifDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckTakhfif
        public bool CheckTakhfif(int idElamAvarez,int ShomareHesabId,byte ShooroShenaseGhabz)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_CheckTakhfif(idElamAvarez, ShomareHesabId, ShooroShenaseGhabz).FirstOrDefault();
                return Convert.ToBoolean(k.Takhfif);
            }
        }
        #endregion
    }
}