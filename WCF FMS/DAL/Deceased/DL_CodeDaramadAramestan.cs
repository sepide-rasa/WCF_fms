using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_CodeDaramadAramestan
    {
        #region Detail
        public OBJ_CodeDaramadAramestan Detail(int id, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblCodeDaramadAramestanSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_CodeDaramadAramestan
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldCodeDaramadId = q.fldCodeDaramadId,
                        fldIP = q.fldIP,
                        fldorganid = q.fldorganid,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldShomareHesab = q.fldShomareHesab,
                        fldMashmooleArzesheAfzoode = q.fldMashmooleArzesheAfzoode,
                        fldMashmooleKarmozd = q.fldMashmooleKarmozd,
                        fldNameVahed = q.fldNameVahed,
                        fldDaramadCode = q.fldDaramadCode
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodeDaramadAramestan> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblCodeDaramadAramestanSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_CodeDaramadAramestan()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldCodeDaramadId = q.fldCodeDaramadId,
                        fldIP = q.fldIP,
                        fldorganid = q.fldorganid,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldShomareHesab = q.fldShomareHesab,
                        fldMashmooleArzesheAfzoode = q.fldMashmooleArzesheAfzoode,
                        fldMashmooleKarmozd = q.fldMashmooleKarmozd,
                        fldNameVahed = q.fldNameVahed,
                        fldDaramadCode = q.fldDaramadCode
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldCodeDaramadId, int OrganId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblCodeDaramadAramestanInsert(fldCodeDaramadId, OrganId, userId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldCodeDaramadId, int OrganId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblCodeDaramadAramestanUpdate(fldId, fldCodeDaramadId, OrganId, userId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblCodeDaramadAramestanDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}