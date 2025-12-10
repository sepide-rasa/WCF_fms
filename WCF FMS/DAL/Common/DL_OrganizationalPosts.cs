using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_OrganizationalPosts
    {
        #region Detail
        public OBJ_OrganizationalPosts Detail(int id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblOrganizationalPostsSelect("fldId", id.ToString(),UserId, 1)
                    .Select(q => new OBJ_OrganizationalPosts
                    {
                        fldChartOrganId = q.fldChartOrganId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldOrgPostCode = q.fldOrgPostCode,
                        fldPID = q.fldPID,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldNameChart = q.fldNameChart,
                        fldOrganId = q.fldOrganId,
                        fldTitlePID = q.fldTitlePID
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_OrganizationalPosts> Select(string FieldName, string FilterValue,int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblOrganizationalPostsSelect(FieldName, FilterValue,UserId, h)
                    .Select(q => new OBJ_OrganizationalPosts()
                    {
                        fldChartOrganId = q.fldChartOrganId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldOrgPostCode = q.fldOrgPostCode,
                        fldPID = q.fldPID,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldNameChart = q.fldNameChart,
                        fldOrganId = q.fldOrganId,
                        fldTitlePID = q.fldTitlePID
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblOrganizationalPostsInsert(fldTitle, fldOrgPostCode,fldChartOrganId, fldPId, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblOrganizationalPostsUpdate(fldId, fldTitle,fldOrgPostCode,fldChartOrganId, fldPId, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblOrganizationalPostsDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_Prs_tblPersonalInfoSelect("CheckOrganPostId", id.ToString(), 0, 0).Any();
                return q;
            }
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var letters = p.spr_tblLetterSignersSelect("fldOrganizationalPostsId", id.ToString(), 0).FirstOrDefault();
                if (letters != null)
                    q = true;
            }
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                var Masolin_d = m.spr_tblMasuolin_DetailSelect("fldOrganPostId", id.ToString(), 0).FirstOrDefault();
                if (Masolin_d != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}