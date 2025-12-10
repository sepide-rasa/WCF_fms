using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Morakhasi
    {
        #region Detail
        public OBJ_Morakhasi Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMorakhasiSelect("fldId", Id.ToString(), 0, 0, 0, 0, OrganId, 1)
                    .Select(q => new OBJ_Morakhasi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodemeli = q.fldCodemeli,
                        fldEmployeeId = q.fldEmployeeId,
                        fldMonth = q.fldMonth,
                        fldMonthName = q.fldMonthName,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldPersonalId = q.fldPersonalId,
                        fldSalAkharinHokm = q.fldSalAkharinHokm,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTedad = q.fldTedad,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldFlag = q.fldFlag
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Morakhasi> Select(string FieldName, string FilterValue, int id, short Year, byte Month, byte NobatPardakht, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMorakhasiSelect(FieldName, FilterValue, id, Year, Month, NobatPardakht, OrganId, h)
                    .Select(q => new OBJ_Morakhasi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodemeli = q.fldCodemeli,
                        fldEmployeeId = q.fldEmployeeId,
                        fldMonth = q.fldMonth,
                        fldMonthName = q.fldMonthName,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldPersonalId = q.fldPersonalId,
                        fldSalAkharinHokm = q.fldSalAkharinHokm,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTedad = q.fldTedad,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldFlag = q.fldFlag
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMorakhasiInsert(PersonalId, Year, Month, NobatePardakht, SalAkharinHokm, Tedad, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id,int PersonalId, short Year,byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMorakhasiUpdate(Id, PersonalId, Year, Month, NobatePardakht, SalAkharinHokm, Tedad, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMorakhasiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PersonalId, short Year, byte Month, byte NobatePardakht, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMorakhasiSelect("CheckSave", PersonalId.ToString(), 0, Year, Month, NobatePardakht,0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblMorakhasiSelect("CheckSave", PersonalId.ToString(), 0, Year, Month, NobatePardakht,0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region MorakhasiGroup
        public List<OBJ_Morakhasi> MorakhasiGroup(string FieldName, short Year, byte Month, byte NobatPardakht, int OrganId, int CostCenter_Chart)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMorakhasiGroupSelect(FieldName, Year, Month, NobatPardakht, OrganId,CostCenter_Chart)
                    .Select(q => new OBJ_Morakhasi()
                    {
                        fldChecked = q.fldChecked,
                        fldCodemeli = q.fldCodemeli,
                        fldMonth = q.fldMonth,
                        fldMorakhasiId = q.fldMorakhasiId,
                        fldName = q.fldName,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldSalAkharinHokm = q.fldSalAkharinHokm,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTedad = q.fldTedad,
                        fldYear = q.fldYear,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}