using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_EtelaatEydi
    {
        #region Detail
        public OBJ_EtelaatEydi Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblEtelaatEydiSelect("fldId", Id.ToString(), 0, 0, 0, OrganId, 1)
                    .Select(q => new OBJ_EtelaatEydi()
                    {
                        fldCodemeli = q.fldCodemeli,
                        fldDate = q.fldDate,
                        fldDayCount = q.fldDayCount,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldKosurat = q.fldKosurat,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldFlag=q.fldFlag
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_EtelaatEydi> Select(string FieldName, string FilterValue, int Id, short Year, byte NobatePardakht, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblEtelaatEydiSelect(FieldName, FilterValue, Id, Year, NobatePardakht, OrganId, h)
                    .Select(q => new OBJ_EtelaatEydi()
                    {
                        fldCodemeli = q.fldCodemeli,
                        fldDate = q.fldDate,
                        fldDayCount = q.fldDayCount,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldKosurat = q.fldKosurat,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldFlag = q.fldFlag
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblEtelaatEydiInsert(PersonalId, Year, DayCount, Kosurat, NobatePardakht, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblEtelaatEydiUpdate(Id, PersonalId, Year, DayCount, Kosurat, NobatePardakht, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblEtelaatEydiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region EtelaatEydiGroup
        public List<OBJ_EtelaatEydi> EtelaatEydiGroup(string FieldName, short Sal, byte NobatPardakht,string Value,int OrganId,int CostCenter_Chart)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblEtelaatEydiGroupSelect(FieldName, Sal, NobatPardakht, Value, OrganId, CostCenter_Chart)
                    .Select(q => new OBJ_EtelaatEydi()
                    {
                        fldChecked = q.fldChecked,
                        fldCodemeli = q.fldCodemeli,
                        fldDayCount = q.fldDayCount,
                        fldEtelaatEydiId = q.fldEtelaatEydiId,
                        fldKosurat = q.fldKosurat,
                        fldName = q.fldName,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}