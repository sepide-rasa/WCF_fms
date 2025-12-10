using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Roonevesht
    {
        #region Detail
        public OBJ_Roonevesht Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblRooneveshtSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Roonevesht()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldTitle = q.fldTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Roonevesht> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblRooneveshtSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Roonevesht()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesabCodeDaramadId, string Title, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblRooneveshtInsert(ShomareHesabCodeDaramadId, Title, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabCodeDaramadId, string Title, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblRooneveshtUpdate(Id, ShomareHesabCodeDaramadId, Title, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblRooneveshtDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}