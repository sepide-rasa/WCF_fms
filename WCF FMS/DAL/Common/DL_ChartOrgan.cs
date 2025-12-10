using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_ChartOrgan
    {
        #region Detail
        public OBJ_ChartOrgan Detail(int id,int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblChartOrganSelect("fldId", id.ToString(),UserId, 1)
                    .Select(q => new OBJ_ChartOrgan
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldNoeVahed=q.fldNoeVahed,
                        fldNoeVahedName=q.fldNoeVahedName,
                        fldOrganId=q.fldOrganId,
                        fldOrganizationName=q.fldOrganizationName,
                        fldPId=q.fldPId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ChartOrgan> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblChartOrganSelect(FieldName, FilterValue,UserId, h)
                    .Select(q => new OBJ_ChartOrgan()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldNoeVahed = q.fldNoeVahed,
                        fldNoeVahedName = q.fldNoeVahedName,
                        fldOrganId = q.fldOrganId,
                        fldOrganizationName = q.fldOrganizationName,
                        fldPId = q.fldPId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblChartOrganInsert(fldTitle, fldPId, fldOrganId, fldNoeVahed, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblChartOrganUpdate(fldId, fldTitle, fldPId, fldOrganId, fldNoeVahed, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblChartOrganDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var m = p.spr_tblOrganizationalPostsSelect("fldChartOrganId", id.ToString(), 0, 0).FirstOrDefault();
                if (m != null)
                    q = true;
            }
            using (RasaFMSPayRollDBEntities m = new RasaFMSPayRollDBEntities())
            {
                var Special = m.spr_tblSpecialPermissionSelect("fldChartOrganId", id.ToString(), 0).FirstOrDefault();
                if (Special != null)
                    q = true;
            }
            //using (BudgetEntities p = new BudgetEntities())
            //{
            //    var Project = p.spr_tblProject_FaaliyatSelect("CheckChartOrganId", id.ToString(),"",0, 0, 0).FirstOrDefault();
            //    if(Project!=null)
            //        q = true;
            //}
            return q;
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Title, int? OrganId, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblChartOrganSelect("CheckTitle", Title,0, 0).Where(l => l.fldOrganId == OrganId).Any();

                }
                else
                {
                    var query = p.spr_tblChartOrganSelect("CheckTitle", Title,0, 0).Where(l => l.fldOrganId == OrganId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

    }
}