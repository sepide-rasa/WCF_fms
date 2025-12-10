using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SpecialPermission
    {
        #region Detail
        public OBJ_SpecialPermission Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSpecialPermissionSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_SpecialPermission()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldChartOrganId=q.fldChartOrganId,
                        fldOpertionId=q.fldOpertionId,
                        fldUserSelectId = q.fldUserSelectId,
                        fldNameEmloyee = q.fldNameEmloyee,
                        fldTitleChart = q.fldTitleChart,
                        fldTitleOpr = q.fldTitleOpr
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SpecialPermission> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSpecialPermissionSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_SpecialPermission()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldChartOrganId = q.fldChartOrganId,
                        fldOpertionId = q.fldOpertionId,
                        fldUserSelectId = q.fldUserSelectId,
                        fldNameEmloyee = q.fldNameEmloyee,
                        fldTitleChart = q.fldTitleChart,
                        fldTitleOpr = q.fldTitleOpr
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int UserSelectId, int ChartOrganId,int OpertionId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSpecialPermissionInsert(UserSelectId, ChartOrganId, OpertionId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int UserSelectId, int ChartOrganId, int OpertionId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSpecialPermissionUpdate(Id, UserSelectId, ChartOrganId, OpertionId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSpecialPermissionDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}