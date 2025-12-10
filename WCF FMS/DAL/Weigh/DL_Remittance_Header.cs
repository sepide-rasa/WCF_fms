using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_Remittance_Header
    {
        #region Detail
        public OBJ_Remittance_Header Detail(int id,int OrganId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var k = p.spr_tblRemittance_HeaderSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_Remittance_Header
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldAshkhasiId = q.fldAshkhasiId,
                        fldIP = q.fldIP,
                        fldStatus = q.fldStatus,
                        fldStartDate = q.fldStartDate,
                        fldEndDate = q.fldEndDate,
                        fldOrganId = q.fldOrganId,
                        fldStatusName = q.fldStatusName,
                        fldKalaName = q.fldKalaName,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldFamilyName = q.fldFamilyName,
                        fldCodemeli = q.fldCodemeli,
                        fldTitle = q.fldTitle,
                        fldChartOrganEjraeeId = q.fldChartOrganEjraeeId,
                        fldNameNoeHavale = q.fldNameNoeHavale,
                        fldEmployId = q.fldEmployId,
                        fldNameTahvilGirande = q.fldNameTahvilGirande,
                        fldNameAshkhas_Chart = q.fldNameAshkhas_Chart,
                        fldNameChart = q.fldNameChart,
                        fldFileId=q.fldFileId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Remittance_Header> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblRemittance_HeaderSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_Remittance_Header()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldAshkhasiId = q.fldAshkhasiId,
                        fldIP = q.fldIP,
                        fldStatus = q.fldStatus,
                        fldStartDate = q.fldStartDate,
                        fldEndDate = q.fldEndDate,
                        fldOrganId = q.fldOrganId,
                        fldStatusName = q.fldStatusName,
                        fldKalaName = q.fldKalaName,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldFamilyName = q.fldFamilyName,
                        fldCodemeli = q.fldCodemeli,
                        fldTitle = q.fldTitle,
                        fldChartOrganEjraeeId=q.fldChartOrganEjraeeId,
                        fldNameNoeHavale=q.fldNameNoeHavale,
                        fldEmployId=q.fldEmployId,
                        fldNameTahvilGirande=q.fldNameTahvilGirande,
                        fldNameAshkhas_Chart=q.fldNameAshkhas_Chart,
                        fldNameChart=q.fldNameChart,
                        fldFileId = q.fldFileId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title,int? fldAshkhasiId, bool fldStatus,byte[] fldFile,string fldPassvand, string fldStartDate, string fldEndDate, System.Data.DataTable detail, int userId, int OrganId,
            string DescHeader,int? OrganizationalUint,int Receiver, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {

                p.spr_tblRemittance_HeaderInsert(fldAshkhasiId, fldStatus,fldFile,fldPassvand,fldStartDate, fldEndDate, detail, userId, OrganId, DescHeader,Receiver, OrganizationalUint, IP, Title);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldHeaderId,string Title, int? fldAshkhasiId, bool fldStatus, string fldStartDate, string fldEndDate,byte[] fldFile,string fldPassvand,
            int? fldFileId, System.Data.DataTable detail, int userId, int OrganId, string DescHeader,int? OrganizationalUint,int Receiver, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblRemittance_HeaderUpdate(fldHeaderId, fldAshkhasiId, fldStatus, fldStartDate, fldEndDate,fldFileId,fldFile,fldPassvand, detail, userId, OrganId, DescHeader
                    ,Receiver,OrganizationalUint, IP, Title);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblRemittance_HeaderDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region SelectSumKalaHavale
        public List<OBJ_KalaHavale> SelectSumKalaHavale(string FieldName, string FilterValue, int HavaleId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_SelectSumKalaHavale(FieldName, FilterValue,HavaleId)
                    .Select(q => new OBJ_KalaHavale()
                    {
                        fldMaxTon = q.fldMaxTon,
                        fldNameKala = q.fldNameKala,
                        fldSumKala = q.fldSumKala,
                        fldBaghimande = q.fldBaghimande,
                        fldKalaid = q.fldKalaid,
                        fldNameHeader = q.fldNameHeader
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region SelectSumKalaHavale_Detail
        public List<OBJ_SumKalaHavale_Detail> SelectSumKalaHavale_Detail(string FieldName, string FilterValue,int HavaleId, int IdKala)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_SelectSumKalaHavale_Detail(FieldName,FilterValue,HavaleId, IdKala)
                    .Select(q => new OBJ_SumKalaHavale_Detail()
                    {
                        fldId = q.fldId,
                        fldNameKala = q.fldNameKala,
                        fldVaznKol = q.fldVaznKol,
                        fldVaznKhals = q.fldVaznKhals,
                        fldRemittanceId = q.fldRemittanceId,
                        fldTarikhVaznKhali = q.fldTarikhVaznKhali,
                        fldNameRanande = q.fldNameRanande,
                        fldNamePlace = q.fldNamePlace,
                        fldPlaque = q.fldPlaque,
                        fldTarikh_TimeTozin = q.fldTarikh_TimeTozin,
                        fldIsporName = q.fldIsporName,
                        fldVaznKhali = q.fldVaznKhali,
                        fldNameKhodro = q.fldNameKhodro,
                        fldNameHavale = q.fldNameHavale,
                        fldNameBaskool = q.fldNameBaskool
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}