using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_MohdoodiyatMohasebat_User
    {
        #region Detail
        public OBJ_MohdoodiyatMohasebat_User Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMohdoodiyatMohasebat_UserSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MohdoodiyatMohasebat_User()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIdUser = q.fldIdUser,
                        fldMahdoodiyatMohasebatId = q.fldMahdoodiyatMohasebatId,
                        fldNameEmployee = q.fldNameEmployee
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MohdoodiyatMohasebat_User> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMohdoodiyatMohasebat_UserSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MohdoodiyatMohasebat_User()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIdUser = q.fldIdUser,
                        fldMahdoodiyatMohasebatId = q.fldMahdoodiyatMohasebatId,
                        fldNameEmployee = q.fldNameEmployee
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MahdoodiyatMohasebatId, int IdUser, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMohdoodiyatMohasebat_UserInsert(IdUser,MahdoodiyatMohasebatId,  UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MahdoodiyatMohasebatId, int IdUser, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMohdoodiyatMohasebat_UserUpdate(Id, IdUser, MahdoodiyatMohasebatId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMohdoodiyatMohasebat_UserDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}