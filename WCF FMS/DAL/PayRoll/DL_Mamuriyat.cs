using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mamuriyat
    {
        #region Detail
        public OBJ_Mamuriyat Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMamuriyatSelect("fldId", Id.ToString(), 0, 0, 0, 0, OrganId, 1)
                    .Select(q => new OBJ_Mamuriyat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBa10 = q.fldBa10,
                        fldBa20 = q.fldBa20,
                        fldBa30 = q.fldBa30,
                        fldBaBeytute = q.fldBaBeytute,
                        fldBe10 = q.fldBe10,
                        fldBe20 = q.fldBe20,
                        fldBe30 = q.fldBe30,
                        fldBeduneBeytute = q.fldBeduneBeytute,
                        fldCodemeli = q.fldCodemeli,
                        fldMonth = q.fldMonth,
                        fldMonthName = q.fldMonthName,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldFlag = q.fldFlag
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mamuriyat> Select(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMamuriyatSelect(FieldName, FilterValue, Id, Year, Month, NobatPardakht, OrganId, h)
                    .Select(q => new OBJ_Mamuriyat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBa10 = q.fldBa10,
                        fldBa20 = q.fldBa20,
                        fldBa30 = q.fldBa30,
                        fldBaBeytute = q.fldBaBeytute,
                        fldBe10 = q.fldBe10,
                        fldBe20 = q.fldBe20,
                        fldBe30 = q.fldBe30,
                        fldBeduneBeytute = q.fldBeduneBeytute,
                        fldCodemeli = q.fldCodemeli,
                        fldMonth = q.fldMonth,
                        fldMonthName = q.fldMonthName,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldFlag = q.fldFlag
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30, 
            byte Be10, byte Be20, byte Be30, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMamuriyatInsert(PersonalId, Year, Month, NobatePardakht, BaBeytute, BeduneBeytute, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30
            , byte Be10, byte Be20, byte Be30, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMamuriyatUpdate(Id, PersonalId, Year, Month, NobatePardakht, BaBeytute, BeduneBeytute, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMamuriyatDelete(Id, UserId);
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
                    q = p.spr_tblMamuriyatSelect("CheckSave", PersonalId.ToString(), 0, Year, Month, NobatePardakht,0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblMamuriyatSelect("CheckSave", PersonalId.ToString(), 0, Year, Month, NobatePardakht,0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region MamuriyatGroup
        public List<OBJ_Mamuriyat> MamuriyatGroup(string FieldName, short Year, byte Month, byte NobatPardakht,int OrganId, int CostCenter_Chart)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMamuriyatGroupSelect(FieldName, Year, Month, NobatPardakht, OrganId,CostCenter_Chart)
                    .Select(q => new OBJ_Mamuriyat()
                    {
                        fldBa10 = q.fldBa10,
                        fldBa20 = q.fldBa20,
                        fldBa30 = q.fldBa30,
                        fldBaBeytute = q.fldBaBeytute,
                        fldBe10 = q.fldBe10,
                        fldBe20 = q.fldBe20,
                        fldBe30 = q.fldBe30,
                        fldBeduneBeytute = q.fldBeduneBeytute,
                        fldChecked = q.fldChecked,
                        fldCodemeli = q.fldCodemeli,
                        fldMamuriyatId = q.fldMamuriyatId,
                        fldMonth = q.fldMonth,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldYear = q.fldYear,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}