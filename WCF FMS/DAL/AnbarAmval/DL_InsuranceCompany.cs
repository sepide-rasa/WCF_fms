using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.DAL.AnbarAmval
{
    public class DL_InsuranceCompany
    {
        #region Detail
        public OBJ_InsuranceCompany Detail(int id)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var k = p.spr_tblInsuranceCompanySelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_InsuranceCompany
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldFileId = q.fldFileId,
                        fldName=q.fldName,
                        fldIP=q.fldIp,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_InsuranceCompany> Select(string FieldName, string FilterValue, int h)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var test = p.spr_tblInsuranceCompanySelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_InsuranceCompany()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldFileId = q.fldFileId,
                        fldName = q.fldName,
                        fldIP = q.fldIp,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName,byte[] fldFile,string Pasvand, int userId, string Desc,int OrganId,string IP)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblInsuranceCompanyInsert(fldName, fldFile, Pasvand, userId, Desc,OrganId,IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int FileId, byte[] fldFile, string Pasvand, int userId, string Desc, int OrganId, string IP)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblInsuranceCompanyUpdate(fldId, fldName, FileId, fldFile, Pasvand, userId, Desc,OrganId,IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblInsuranceCompanyDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}