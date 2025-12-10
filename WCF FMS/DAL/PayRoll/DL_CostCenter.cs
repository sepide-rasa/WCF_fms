using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_CostCenter
    {
        #region Detail
        public OBJ_CostCenter Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblCostCenterSelect("fldId", Id.ToString(), OrganId.ToString(), 1)
                    .Select(q => new OBJ_CostCenter()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldEmploymentCenterId = q.fldEmploymentCenterId,
                        fldReportTypeId = q.fldReportTypeId,
                        fldTypeOfCostCenterId = q.fldTypeOfCostCenterId,
                        fldReportTypeName = q.fldReportTypeName,
                        EmploymentName = q.EmploymentName,
                        TypecenterTitle = q.TypecenterTitle,
                        fldorganid = q.fldorganid
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CostCenter> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblCostCenterSelect(FieldName, FilterValue, FilterValue2, h)
                    .Select(q => new OBJ_CostCenter()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldEmploymentCenterId = q.fldEmploymentCenterId,
                        fldReportTypeId = q.fldReportTypeId,
                        fldTypeOfCostCenterId = q.fldTypeOfCostCenterId,
                        fldReportTypeName = q.fldReportTypeName,
                        EmploymentName = q.EmploymentName,
                        TypecenterTitle = q.TypecenterTitle,
                        fldorganid = q.fldorganid
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, int ReportTypeId, int TypeOfCostCenterId, int EmploymentCenterId, int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblCostCenterInsert(Title, ReportTypeId, TypeOfCostCenterId, EmploymentCenterId, UserId, Desc, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title,int ReportTypeId,int TypeOfCostCenterId,int EmploymentCenterId,int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblCostCenterUpdate(Id, Title, ReportTypeId, TypeOfCostCenterId, EmploymentCenterId, UserId, Desc,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblCostCenterDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var Mohasebat = p.spr_tblMohasebat_PersonalInfoSelect("CheckCostCenterId", Id.ToString(), 0, 0).FirstOrDefault();
                var Personal = p.spr_Pay_tblPersonalInfoSelect("CheckCostCenterId", Id.ToString(),0, 1).FirstOrDefault();
                if (Mohasebat != null || Personal != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}