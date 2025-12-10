using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_ReferralRules
    {
        #region Detail
        public OBJ_ReferralRules Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblReferralRulesSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_ReferralRules()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldPostErjaDahandeId = q.fldPostErjaDahandeId,
                        fldPostErjaGirandeId = q.fldPostErjaGirandeId,
                        fldTitleErjaDahande = q.fldTitleErjaDahande,
                        fldTitleErjaGirande = q.fldTitleErjaGirande,
                        fldChartEjraeeGirandeId = q.fldChartEjraeeGirandeId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ReferralRules> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblReferralRulesSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_ReferralRules()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldPostErjaDahandeId = q.fldPostErjaDahandeId,
                        fldPostErjaGirandeId = q.fldPostErjaGirandeId,
                        fldTitleErjaDahande = q.fldTitleErjaDahande,
                        fldTitleErjaGirande = q.fldTitleErjaGirande,
                        fldChartEjraeeGirandeId = q.fldChartEjraeeGirandeId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldPostErjaDahandeId, int? fldPostErjaGirandeId, int? fldChartEjraeeGirandeId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblReferralRulesInsert(fldPostErjaDahandeId, fldPostErjaGirandeId, fldChartEjraeeGirandeId, UserId, OrganID, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldPostErjaDahandeId, int? fldPostErjaGirandeId, int? fldChartEjraeeGirandeId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblReferralRulesUpdate(Id, fldPostErjaDahandeId, fldPostErjaGirandeId, fldChartEjraeeGirandeId, UserId, OrganID, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int fldPostErjaDahandeId, int OrganErjaGirande, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblReferralRulesDelete(fldPostErjaDahandeId, OrganErjaGirande, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}