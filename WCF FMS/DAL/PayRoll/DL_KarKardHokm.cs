using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_KarKardHokm
    {
        #region Detail
        public OBJ_KarKardHokm Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKarKardHokmSelect("fldId", Id.ToString(), "", 0,null,null,0)
                    .Select(q => new OBJ_KarKardHokm()
                    {
                       
                        fldId = q.fldId,
                        fldHokmId=q.fldHokmId,
                        fldKarkardId=q.fldKarkardId,
                        fldRoze=q.fldRoze
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_KarKardHokm> Select(string FieldName, string FilterValue, string FilterValue2, int KarkardId, decimal Roz, decimal Gheybat, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKarKardHokmSelect(FieldName, FilterValue, FilterValue2, KarkardId, Roz,Gheybat, h)
                    .Select(q => new OBJ_KarKardHokm()
                    {
                        fldId = q.fldId,
                        fldHokmId = q.fldHokmId,
                        fldKarkardId = q.fldKarkardId,
                        fldRoze = q.fldRoze,
                        fldGheybat=q.fldGheybat
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarKardHokmInsert(fldKarkardId, fldHokmId, fldRoze, fldGheybat);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId,int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarKardHokmUpdate(fldId,fldKarkardId,fldHokmId,fldRoze, fldGheybat);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarKardHokmDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
      

        
    }
}