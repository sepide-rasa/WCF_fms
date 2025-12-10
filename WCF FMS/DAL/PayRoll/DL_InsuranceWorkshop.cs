using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_InsuranceWorkshop
    {
        #region Detail
        public OBJ_InsuranceWorkshop Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblInsuranceWorkshopSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_InsuranceWorkshop()
                    {
                        fldAddress = q.fldAddress,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldEmployerName = q.fldEmployerName,
                        fldId = q.fldId,
                        fldPersent = q.fldPersent,
                        fldPeyman = q.fldPeyman,
                        fldUserId = q.fldUserId,
                        fldWorkShopName = q.fldWorkShopName,
                        fldWorkShopNum = q.fldWorkShopNum,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_InsuranceWorkshop> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblInsuranceWorkshopSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_InsuranceWorkshop()
                    {
                        fldAddress = q.fldAddress,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldEmployerName = q.fldEmployerName,
                        fldId = q.fldId,
                        fldPersent = q.fldPersent,
                        fldPeyman = q.fldPeyman,
                        fldUserId = q.fldUserId,
                        fldWorkShopName = q.fldWorkShopName,
                        fldWorkShopNum = q.fldWorkShopNum,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman,int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblInsuranceWorkshopInsert(WorkShopName, EmployerName, WorkShopNum, Persent, Address, Peyman, OrganId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman,int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblInsuranceWorkshopUpdate(Id, WorkShopName, EmployerName, WorkShopNum, Persent, Address, Peyman, OrganId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblInsuranceWorkshopDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string WorkShopNum, string Peyman, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblInsuranceWorkshopSelect("CheckWorkShopNum", WorkShopNum,0, 0).Where(l=>l.fldPeyman==Peyman).Any();

                }
                else
                {
                    var query = p.spr_tblInsuranceWorkshopSelect("CheckWorkShopNum", WorkShopNum, 0, 0).Where(l => l.fldPeyman == Peyman).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var Mohasebat = p.spr_tblMohasebat_PersonalInfoSelect("CheckInsuranceWorkShopId", Id.ToString(),0, 0).FirstOrDefault();
                var Personal = p.spr_Pay_tblPersonalInfoSelect("CheckInsuranceWorkShopId", Id.ToString(),0, 1).FirstOrDefault();
                var Karkard = p.spr_tblKarkardMahane_DetailSelect("fldKargahBimeId", Id.ToString(), 1).FirstOrDefault();
                if (Mohasebat != null || Personal != null || Karkard != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}