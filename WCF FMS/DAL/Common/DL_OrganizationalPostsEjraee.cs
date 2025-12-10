using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_OrganizationalPostsEjraee
    {
        #region Detail
        public OBJ_OrganizationalPostsEjraee Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblOrganizationalPostsEjraeeSelect("fldId", Id.ToString(), 0, 1)
                    .Select(q => new OBJ_OrganizationalPostsEjraee()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldTitle = q.fldTitle,
                        fldChartOrganId=q.fldChartOrganId,
                        fldNameChart=q.fldNameChart,
                        fldOrgPostCode=q.fldOrgPostCode,
                        fldPID=q.fldPID,
                        fldTitlePID = q.fldTitlePID
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_OrganizationalPostsEjraee> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblOrganizationalPostsEjraeeSelect(FieldName, FilterValue, UserId, h)
                    .Select(q => new OBJ_OrganizationalPostsEjraee()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldTitle = q.fldTitle,
                        fldChartOrganId = q.fldChartOrganId,
                        fldNameChart = q.fldNameChart,
                        fldOrgPostCode = q.fldOrgPostCode,
                        fldPID = q.fldPID,
                        fldTitlePID = q.fldTitlePID
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblOrganizationalPostsEjraeeInsert(Title, OrgPostCode, ChartOrganId, PID, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblOrganizationalPostsEjraeeUpdate(Id, Title, OrgPostCode, ChartOrganId, PID, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblOrganizationalPostsEjraeeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (AutomationEntities m = new AutomationEntities())
            {
                var co = m.spr_tblCommisionSelect("fldOrganizPostEjraeeID", id.ToString(), 0, 0).FirstOrDefault();
                var Re = m.spr_tblReferralRulesSelect("checkPostErjaDahandeId", id.ToString(), 0, 0).FirstOrDefault();
                var Re1 = m.spr_tblReferralRulesSelect("checkPostErjaGirandeId", id.ToString(), 0, 0).FirstOrDefault();
                if (co != null || Re != null || Re1 != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}