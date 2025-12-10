using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_PayPersonalInfo
    {
        #region Detail
        public OBJ_PayPersonalInfo Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_tblPersonalInfoSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_PayPersonalInfo()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldBimeOmr=q.fldBimeOmr,
                        fldBimeTakmili=q.fldBimeTakmili,
                        fldCostCenterId=q.fldCostCenterId,
                        fldHamsarKarmand=q.fldHamsarKarmand,
                        fldInsuranceWorkShopId=q.fldInsuranceWorkShopId,
                        fldJobeCode=q.fldJobeCode,
                        fldMashagheleSakhtVaZianAvar=q.fldMashagheleSakhtVaZianAvar,
                        fldMazad30Sal=q.fldMazad30Sal,
                        fldMoafDarman=q.fldMoafDarman,
                        fldPasAndaz=q.fldPasAndaz,
                        fldPrs_PersonalInfoId=q.fldPrs_PersonalInfoId,
                        fldSanavatPayanKhedmat=q.fldSanavatPayanKhedmat,
                        fldShomareBime=q.fldShomareBime,
                        fldTypeBimeId=q.fldTypeBimeId,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTitleTypeBime = q.fldTitleTypeBime,
                        fldWorkShopName = q.fldWorkShopName,
                        fldJobDesc = q.fldJobDesc,
                        fldBimeOmrName = q.fldBimeOmrName,
                        fldBimeTakmiliName = q.fldBimeTakmiliName,
                        fldMashagheleSakhtVaZianAvarName = q.fldMashagheleSakhtVaZianAvarName,
                        fldMazadCSalName = q.fldMazadCSalName,
                        fldPasAndazName = q.fldPasAndazName,
                        fldSanavatPayanKhedmatName = q.fldSanavatPayanKhedmatName,
                        fldTitleCostCenter = q.fldTitleCostCenter,
                        fldName_Father = q.fldName_Father,
                        UserName = q.UserName,
                        fldEsargariId=q.fldEsargariId,
                        fldStatusId = q.fldStatusId,
                        fldStatusTitle = q.fldStatusTitle,
                        fldHamsarKarmandName = q.fldHamsarKarmandName,
                        fldNameEmployee = q.fldNameEmployee,
                        fldFamily = q.fldFamily,
                        fldEmployeeId = q.fldEmployeeId,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldNoeEstekhdamTitle = q.fldNoeEstekhdamTitle,
                        fldTarikhMazad30Sal = q.fldTarikhMazad30Sal
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PayPersonalInfo> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_tblPersonalInfoSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_PayPersonalInfo()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldBimeOmr = q.fldBimeOmr,
                        fldBimeTakmili = q.fldBimeTakmili,
                        fldCostCenterId = q.fldCostCenterId,
                        fldHamsarKarmand = q.fldHamsarKarmand,
                        fldInsuranceWorkShopId = q.fldInsuranceWorkShopId,
                        fldJobeCode = q.fldJobeCode,
                        fldMashagheleSakhtVaZianAvar = q.fldMashagheleSakhtVaZianAvar,
                        fldMazad30Sal = q.fldMazad30Sal,
                        fldMoafDarman = q.fldMoafDarman,
                        fldPasAndaz = q.fldPasAndaz,
                        fldPrs_PersonalInfoId = q.fldPrs_PersonalInfoId,
                        fldSanavatPayanKhedmat = q.fldSanavatPayanKhedmat,
                        fldShomareBime = q.fldShomareBime,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTitleTypeBime = q.fldTitleTypeBime,
                        fldWorkShopName = q.fldWorkShopName,
                        fldJobDesc = q.fldJobDesc,
                        fldBimeOmrName = q.fldBimeOmrName,
                        fldBimeTakmiliName = q.fldBimeTakmiliName,
                        fldMashagheleSakhtVaZianAvarName = q.fldMashagheleSakhtVaZianAvarName,
                        fldMazadCSalName = q.fldMazadCSalName,
                        fldPasAndazName = q.fldPasAndazName,
                        fldSanavatPayanKhedmatName = q.fldSanavatPayanKhedmatName,
                        fldTitleCostCenter = q.fldTitleCostCenter,
                        fldName_Father = q.fldName_Father,
                        UserName = q.UserName,
                        fldEsargariId = q.fldEsargariId,
                        fldStatusId = q.fldStatusId,
                        fldStatusTitle = q.fldStatusTitle,
                        fldHamsarKarmandName = q.fldHamsarKarmandName,
                        fldNameEmployee = q.fldNameEmployee,
                        fldFamily = q.fldFamily,
                        fldEmployeeId = q.fldEmployeeId,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldNoeEstekhdamTitle = q.fldNoeEstekhdamTitle,
                        fldTarikhMazad30Sal = q.fldTarikhMazad30Sal
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman,int StatusId, string DateTaghirVaziyat,int? fldTarikhMazad30Sal, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Pay_tblPersonalInfoInsert(Prs_PersonalInfoId, TypeBimeId, ShomareBime, BimeOmr, BimeTakmili, MashagheleSakhtVaZianAvar, CostCenterId, Mazad30Sal
                    , PasAndaz, SanavatPayanKhedmat, JobeCode, InsuranceWorkShopId, HamsarKarmand, MoafDarman, UserId, Desc, StatusId, DateTaghirVaziyat,fldTarikhMazad30Sal);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman, int? fldTarikhMazad30Sal, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Pay_tblPersonalInfoUpdate(Id, Prs_PersonalInfoId, TypeBimeId, ShomareBime, BimeOmr, BimeTakmili, MashagheleSakhtVaZianAvar, CostCenterId, Mazad30Sal
                    , PasAndaz, SanavatPayanKhedmat, JobeCode, InsuranceWorkShopId, HamsarKarmand, MoafDarman, UserId, Desc, fldTarikhMazad30Sal);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Pay_tblPersonalInfoDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var m = p.spr_tblAfradeTahtePoshesheBimeTakmilySelect("CheckPersonalId", id.ToString(), 0,0,0,0,0, 0).FirstOrDefault();
                var x = p.spr_tblKarKardeMahaneSelect("CheckPersonalId", id.ToString(), "", "", 0, 0,0, 1).FirstOrDefault();
                var n = p.spr_tblKosorateParametri_PersonalSelect("CheckPersonalId", id.ToString(), "", "", "",0, 1).FirstOrDefault();
                var z = p.spr_tblKosuratBankSelect("CheckPersonalId", id.ToString(),"","",0, 1).FirstOrDefault();
                var Mamoriyat = p.spr_tblMamuriyatSelect("CheckPersonalId", id.ToString(), 0, 0, 0, 0,0, 1).FirstOrDefault();
                var Mandeh = p.spr_tblMandehPasAndazSelect("CheckPersonalId", id.ToString(),0, 1).FirstOrDefault();
                var Mohasebat = p.spr_tblMohasebatSelect("CheckPersonalId", id.ToString(),"","",0, 1).FirstOrDefault();
                var a = p.spr_tblMohasebat_MamuriyatSelect("CheckPersonalId", id.ToString(),0, 1).FirstOrDefault();
                var s = p.spr_tblMohasebatEzafeKari_TatilKariSelect("CheckPersonalId", id.ToString(),0, 1).FirstOrDefault();
                var Morakhasi = p.spr_tblMorakhasiSelect("CheckPersonalId", id.ToString(), 0, 0, 0, 0, 0, 1).FirstOrDefault();
                var Motalebat = p.spr_tblMotalebateParametri_PersonalSelect("CheckPersonalId", id.ToString(),"","","",0, 1).FirstOrDefault();
                var SayerPardakht = p.spr_tblSayerPardakhtsSelect("CheckPersonalId", id.ToString(), 0, 0, 0, 0, 0,0, 1).FirstOrDefault();
                var ShomareHesab = p.spr_tblShomareHesabPasAndazSelect("CheckPersonalId", id.ToString(),0, 1).FirstOrDefault();
                var Sh = p.spr_tblShomareHesabsSelect("CheckPersonalId", id.ToString(), "", "",0, 1).FirstOrDefault();
                var vam = p.spr_tblVamSelect("CheckPersonalId", id.ToString(),0, 1).FirstOrDefault();
                var K = p.spr_tblKomakGheyerNaghdiSelect("CheckPersonalId", id.ToString(),0, 0, 0, 0, 0, 1).FirstOrDefault();
                var M_Eydi = p.spr_tblMohasebat_EydiSelect("CheckPersonalId", id.ToString(),0, 1).FirstOrDefault();
                if (m != null || x != null || n != null || z != null || Mamoriyat != null || Mandeh != null || Mohasebat != null || a != null || s != null || Morakhasi != null || Motalebat != null || SayerPardakht != null || ShomareHesab != null || Sh != null || vam != null || K != null || M_Eydi != null)
                    q = true;
                return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int Prs_PersonalInfoId, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_Pay_tblPersonalInfoSelect("CheckPrs_PersonalInfoId", Prs_PersonalInfoId.ToString(), 0, 0).Any();

                }
                else
                {
                    var query = p.spr_Pay_tblPersonalInfoSelect("CheckPrs_PersonalInfoId", Prs_PersonalInfoId.ToString(), 0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
       
        #region CheckRepeatedField
        public bool CheckRepeatedField(string FieldName,string Value,int Value2,int id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {

                q = p.spr_Pay_tblPersonalInfoSelect(FieldName, Value.ToString(), Value2, 0).Where(l=>l.fldId!=id).Any();

                
            }
            return q;
        }
        #endregion
       
    }
}