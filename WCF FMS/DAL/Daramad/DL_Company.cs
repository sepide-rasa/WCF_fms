using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Company
    {
        #region Detail
        public OBJ_Company Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCompanySelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Company()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldKarbarId = q.fldKarbarId,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldURL = q.fldURL,
                        fldUserName = q.fldUserName,
                        fldUserNameService = q.fldUserNameService,
                        fldPassService = q.fldPassService,
                        fldOrganId = q.fldOrganId,
                        fldNameOrgan = q.fldNameOrgan
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Company> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCompanySelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Company()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldKarbarId = q.fldKarbarId,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldURL = q.fldURL,
                        fldUserName = q.fldUserName,
                        fldUserNameService = q.fldUserNameService,
                        fldPassService = q.fldPassService,
                        fldOrganId = q.fldOrganId,
                        fldNameOrgan = q.fldNameOrgan
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, string ShenaseMeli, int KarbarId, string URL, string UserNameService, string PassService,int? OrganId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCompanyInsert(Title, ShenaseMeli, KarbarId, URL, UserId, Desc, UserNameService, PassService, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, string ShenaseMeli, int KarbarId, string URL, string UserNameService, string PassService, int? OrganId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCompanyUpdate(Id, Title, ShenaseMeli, KarbarId, URL, UserId, Desc, UserNameService, PassService, OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCompanyDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var Parametr = p.spr_tblParametrHesabdariSelect("fldCompanyId", Id.ToString(), 0).FirstOrDefault();
                if (Parametr != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}