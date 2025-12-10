using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_KarkardMahane_Detail
    {
        #region Detail
        public OBJ_KarkardMahane_Detail Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKarkardMahane_DetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_KarkardMahane_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldEmployerName = q.fldEmployerName,
                        fldKargahBimeId = q.fldKargahBimeId,
                        fldKarkard = q.fldKarkard,
                        fldKarkardMahaneId = q.fldKarkardMahaneId,
                        fldWorkShopName = q.fldWorkShopName,
                        fldWorkShopNum = q.fldWorkShopNum
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_KarkardMahane_Detail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKarkardMahane_DetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_KarkardMahane_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldEmployerName = q.fldEmployerName,
                        fldKargahBimeId = q.fldKargahBimeId,
                        fldKarkard = q.fldKarkard,
                        fldKarkardMahaneId = q.fldKarkardMahaneId,
                        fldWorkShopName = q.fldWorkShopName,
                        fldWorkShopNum = q.fldWorkShopNum
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int KarkardMahaneId, int Karkard, int KargahBimeId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarkardMahane_DetailInsert(KarkardMahaneId, Karkard, KargahBimeId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int KarkardMahaneId, int Karkard, int KargahBimeId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarkardMahane_DetailUpdate(Id, KarkardMahaneId, Karkard, KargahBimeId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarkardMahane_DetailDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}