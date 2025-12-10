using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
namespace WCF_FMS.DAL.PayRoll
{
    public class DL_CalcHeader
    {
        #region Detail
        public OBJ_CalcHeader Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.prs_tblCalcHeaderSelect("fldId", id.ToString(),0,0,0,0,0, 1)
                    .Select(q => new OBJ_CalcHeader
                    {
                        fldCalcType=q.fldCalcType,
                        fldCalcTypeName=q.fldCalcTypeName,
                        fldDate=q.fldDate,
                        fldId=q.fldId,
                        fldIp=q.fldIp,
                        fldMonth=q.fldMonth,
                        fldMonthName=q.fldMonthName,
                        fldName=q.fldName,
                        fldNameOrgan=q.fldNameOrgan,
                        fldNobatPardakhtId=q.fldNobatPardakhtId,
                        fldOrganId=q.fldOrganId,
                        fldQueue=q.fldQueue,
                        fldQueueTime=q.fldQueueTime,
                        fldStatus=q.fldStatus,
                        fldStatusName=q.fldStatusName,
                        fldTarikh=q.fldTarikh,
                        fldUserId=q.fldUserId,
                        fldYear=q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CalcHeader> Select(string FieldName, string FilterValue,short Year, byte Month, int NobatPardakhtId,int OrganId, int UserId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.prs_tblCalcHeaderSelect(FieldName, FilterValue,Year,Month,NobatPardakhtId,UserId,OrganId, h)
                    .Select(q => new OBJ_CalcHeader()
                    {
                        fldCalcType = q.fldCalcType,
                        fldCalcTypeName = q.fldCalcTypeName,
                        fldDate = q.fldDate,
                        fldId = q.fldId,
                        fldIp = q.fldIp,
                        fldMonth = q.fldMonth,
                        fldMonthName = q.fldMonthName,
                        fldName = q.fldName,
                        fldNameOrgan = q.fldNameOrgan,
                        fldNobatPardakhtId = q.fldNobatPardakhtId,
                        fldOrganId = q.fldOrganId,
                        fldQueue = q.fldQueue,
                        fldQueueTime = q.fldQueueTime,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikh = q.fldTarikh,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public int Insert(short Year, byte Month, int NobatPardakhtId, byte Status, string PersonalId, byte CalcType,int OrganId, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter fldId = new System.Data.Entity.Core.Objects.ObjectParameter("fldid", typeof(int));
                p.prs_tblCalcHeaderInsert(fldId,Year, Month,NobatPardakhtId,OrganId,Status, IP, UserId,PersonalId,CalcType);
                return Convert.ToInt16(fldId.Value);
            }
        }
        #endregion
        #region Delete
        public string Delete(short Year,byte Month, int NobatPardakhtId, int OrganId, string TypeEstekhdam, string CostCenterId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.prs_tblCalcHeaderDelete(Year, Month, NobatPardakhtId, OrganId, TypeEstekhdam, CostCenterId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}