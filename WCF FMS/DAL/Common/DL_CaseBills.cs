using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_CaseBills
    {
        #region Detail
        public OBJ_CaseBills Detail(int id,int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblCaseBillsSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_CaseBills
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldAshkhasId = q.fldAshkhasId,
                        fldBillsTypeId = q.fldBillsTypeId,
                        fldCentercoId = q.fldCentercoId,
                        fldFileNum = q.fldFileNum,
                        fldOrganChartId = q.fldOrganChartId,
                        fldOrganId = q.fldOrganId,
                        fldName_BillsType = q.fldName_BillsType,
                        fldNameCenter = q.fldNameCenter,
                        fldName_shakhs = q.fldName_shakhs,
                        fldCodeMelli = q.fldCodeMelli,
                        fldTitle_chartOrgan = q.fldTitle_chartOrgan,
                        fldName_Organ = q.fldName_Organ,
                        fldShakhs_Type = q.fldShakhs_Type
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CaseBills> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblCaseBillsSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_CaseBills()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldAshkhasId = q.fldAshkhasId,
                        fldBillsTypeId = q.fldBillsTypeId,
                        fldCentercoId = q.fldCentercoId,
                        fldFileNum = q.fldFileNum,
                        fldOrganChartId = q.fldOrganChartId,
                        fldOrganId = q.fldOrganId,
                        fldName_BillsType = q.fldName_BillsType,
                        fldNameCenter = q.fldNameCenter,
                        fldName_shakhs = q.fldName_shakhs,
                        fldCodeMelli = q.fldCodeMelli,
                        fldTitle_chartOrgan = q.fldTitle_chartOrgan,
                        fldName_Organ = q.fldName_Organ,
                        fldShakhs_Type = q.fldShakhs_Type
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int BillsTypeId, int FileNum, int CentercoId, int OrganId, int OrganChartId,int? AshkhasId, string IP, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblCaseBillsInsert(BillsTypeId, FileNum, CentercoId, OrganId, OrganChartId, AshkhasId, Desc, IP, userId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int BillsTypeId, int FileNum, int CentercoId, int OrganId, int OrganChartId, int? AshkhasId, string IP, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblCaseBillsUpdate(Id, BillsTypeId, FileNum, CentercoId, OrganId, OrganChartId, AshkhasId, Desc, IP, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblCaseBillsDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int FileNum, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblCaseBillsSelect("CheckFileNum", FileNum.ToString(), 0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblCaseBillsSelect("CheckFileNum", FileNum.ToString(), 0, 0).FirstOrDefault();
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