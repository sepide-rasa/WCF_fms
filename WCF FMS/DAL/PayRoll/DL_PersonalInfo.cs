using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_PersonalInfo
    {
        #region Detail
        public OBJ_PersonalInfo Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Prs_tblPersonalInfoSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_PersonalInfo()
                    {
                        fldId = q.fldId,
                        fldChartOrganId = q.fldChartOrganId,
                        fldEmployeeId = q.fldEmployeeId,
                        fldEsargariId = q.fldEsargariId,
                        fldNameJensiyat = q.fldNameJensiyat,
                        fldNezamVazifeId = q.fldNezamVazifeId,
                        fldAddress = q.fldAddress,
                        fldCodePosti = q.fldCodePosti,
                        fldRasteShoghli = q.fldRasteShoghli,
                        fldReshteShoghli = q.fldReshteShoghli,
                        fldVaziyatEsargariTitle = q.fldVaziyatEsargariTitle,
                        fldSh_MojavezEstekhdam = q.fldSh_MojavezEstekhdam,
                        fldSh_Personali = q.fldSh_Personali,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldTabaghe = q.fldTabaghe,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        fldTarikhMajavezEstekhdam = q.fldTarikhMajavezEstekhdam,
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        fldSharhEsargari = q.fldSharhEsargari,
                        fldMeliyatName = q.fldMeliyatName,
                        fldMadrakTahsiliTitle = q.fldMadrakTahsiliTitle,
                        fldNameEmployee = q.fldNameEmployee,
                        fldNameMahalTavalod = q.fldNameMahalTavalod,
                        fldNameMahlSodoor = q.fldNameMahlSodoor,
                        fldNameOrgan = q.fldNameOrgan,
                        fldNezamVazifeTitle = q.fldNezamVazifeTitle,
                        fldTitleChartOrgan = q.fldTitleChartOrgan,
                        fldCodemeli = q.fldCodemeli,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate,
                        fldOrganPostId = q.fldOrganPostId,
                        fldReshteTahsiliTitle = q.fldReshteTahsiliTitle,
                        NamePostOran = q.NamePostOran,
                        fldName_FamilyEmployee = q.fldName_FamilyEmployee,
                        fldOrganId = q.fldOrganId,
                        fldIdStatus = q.fldIdStatus,
                        fldNoeEstekhdam = q.fldNoeEstekhdam,
                        fldTitleStatus = q.fldTitleStatus,
                        fldJensiyat = q.fldJensiyat,
                        fldReshteId = q.fldReshteId,
                        fldMahalSodoorId = q.fldMahalSodoorId,
                        fldMahalTavalodId = q.fldMahalTavalodId,
                        fldMeliyat = q.fldMeliyat,
                        fldMadrakId = q.fldMadrakId,
                        fldTarikhSodoor = q.fldTarikhSodoor,
                        fldTaaholId = q.fldTaaholId,
                        TitleNoeEstekhdam = q.TitleNoeEstekhdam,
                        TitleOrganPostEjraee = q.TitleOrganPostEjraee,
                        TitleChartOrganEjraee = q.TitleChartOrganEjraee,
                        fldOrganPostEjraeeId = q.fldOrganPostEjraeeId,
                        fldMobile = q.fldMobile,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PersonalInfo> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Prs_tblPersonalInfoSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_PersonalInfo()
                    {
                        fldId = q.fldId,
                        fldChartOrganId = q.fldChartOrganId,
                        fldEmployeeId = q.fldEmployeeId,
                        fldEsargariId = q.fldEsargariId,
                        fldNezamVazifeId = q.fldNezamVazifeId,
                        fldNameJensiyat = q.fldNameJensiyat,
                        fldAddress = q.fldAddress,
                        fldCodePosti = q.fldCodePosti,
                        fldVaziyatEsargariTitle = q.fldVaziyatEsargariTitle,
                        fldRasteShoghli = q.fldRasteShoghli,
                        fldReshteShoghli = q.fldReshteShoghli,
                        fldSh_MojavezEstekhdam = q.fldSh_MojavezEstekhdam,
                        fldSh_Personali = q.fldSh_Personali,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldTabaghe = q.fldTabaghe,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        fldTarikhMajavezEstekhdam = q.fldTarikhMajavezEstekhdam,
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        fldSharhEsargari = q.fldSharhEsargari,
                        fldMeliyatName = q.fldMeliyatName,
                        fldMadrakTahsiliTitle = q.fldMadrakTahsiliTitle,
                        fldNameEmployee = q.fldNameEmployee,
                        fldNameMahalTavalod = q.fldNameMahalTavalod,
                        fldNameMahlSodoor = q.fldNameMahlSodoor,
                        fldNameOrgan = q.fldNameOrgan,
                        fldNezamVazifeTitle = q.fldNezamVazifeTitle,
                        fldTitleChartOrgan = q.fldTitleChartOrgan,
                        fldCodemeli = q.fldCodemeli,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate,
                        fldOrganPostId = q.fldOrganPostId,
                        fldReshteTahsiliTitle = q.fldReshteTahsiliTitle,
                        NamePostOran = q.NamePostOran,
                        fldName_FamilyEmployee = q.fldName_FamilyEmployee,
                        fldOrganId = q.fldOrganId,
                        fldIdStatus = q.fldIdStatus,
                        fldNoeEstekhdam = q.fldNoeEstekhdam,
                        fldTitleStatus = q.fldTitleStatus,
                        fldJensiyat = q.fldJensiyat,
                        fldReshteId = q.fldReshteId,
                        fldMahalSodoorId = q.fldMahalSodoorId,
                        fldMahalTavalodId = q.fldMahalTavalodId,
                        fldMeliyat = q.fldMeliyat,
                        fldMadrakId = q.fldMadrakId,
                        fldTarikhSodoor = q.fldTarikhSodoor,
                        fldTaaholId = q.fldTaaholId,
                        TitleNoeEstekhdam = q.TitleNoeEstekhdam,
                        TitleOrganPostEjraee = q.TitleOrganPostEjraee,
                        TitleChartOrganEjraee = q.TitleChartOrganEjraee,
                        fldOrganPostEjraeeId = q.fldOrganPostEjraeeId,
                        fldMobile = q.fldMobile
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, byte[] Image,string Pasvand,string DateTaghirVaziyat,int NoeEstekhdamId,string Tarikh,int UserId)
        {
            using (RasaFMSCommonDBEntities c = new RasaFMSCommonDBEntities())
            {
                //int EmployeeId = 0;
                //var q = c.spr_tblEmployeeSelect("fldCodemeli", CodeMeli, 1).FirstOrDefault();
                //if (q != null)
                //{
                //    EmployeeId = q.fldId;
                //}
                //if (EmployeeId!=0)
                //{
                //    RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities();
                //    p.spr_Prs_tblPersonalInfoInsert(EmployeeId, PersonalInfo.fldEsargariId, PersonalInfo.fldSharhEsargari, PersonalInfo.fldSh_Personali, PersonalInfo.fldOrganPostId, PersonalInfo.fldRasteShoghli, PersonalInfo.fldReshteShoghli, PersonalInfo.fldTarikhEstekhdam, PersonalInfo.fldTabaghe
                //        , PersonalInfo.fldSh_MojavezEstekhdam, PersonalInfo.fldTarikhMajavezEstekhdam, PersonalInfo.fldUserId, PersonalInfo.fldDesc, PersonalInfo.fldIdStatus, DateTaghirVaziyat, NoeEstekhdamId, Tarikh);
                //    return "ذخیره با موفقیت انجام شد.";
                //}
                //else
                //{
                    RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities();
                    p.spr_Prs_tblPersonalInfoInsert_Employee(Employee_Detail.fldSh_Shenasname, Employee_Detail.fldTarikhTavalod, Employee_Detail.fldMahalTavalodId, Employee_Detail.fldMahalSodoorId, Employee_Detail.fldAddress, Employee_Detail.fldCodePosti, PersonalInfo.fldEsargariId, PersonalInfo.fldSharhEsargari
                        , PersonalInfo.fldSh_Personali, PersonalInfo.fldMadrakId, PersonalInfo.fldReshteId, PersonalInfo.fldNezamVazifeId, PersonalInfo.fldOrganPostId, PersonalInfo.fldRasteShoghli, PersonalInfo.fldReshteShoghli, PersonalInfo.fldTarikhEstekhdam, PersonalInfo.fldTabaghe, PersonalInfo.fldMeliyat, PersonalInfo.fldSh_MojavezEstekhdam
                        , PersonalInfo.fldTarikhMajavezEstekhdam, UserId, PersonalInfo.fldDesc, Image, PersonalInfo.fldName, PersonalInfo.fldFamily, PersonalInfo.fldFatherName, PersonalInfo.fldCodemeli, PersonalInfo.fldJensiyat, PersonalInfo.fldIdStatus, DateTaghirVaziyat, NoeEstekhdamId, Tarikh, Employee_Detail.fldTaaholId, Employee_Detail.fldTarikhSodoor, Employee.fldStatus, Pasvand, Employee.fldId, PersonalInfo.fldOrganPostEjraeeId,PersonalInfo.fldTel,PersonalInfo.fldMobile);
                    return "ذخیره با موفقیت انجام شد.";
                //}
            }
        }
        #endregion
        #region Update
        public string Update(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, int FileId, byte[] Image, string Pasvand, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Prs_tblPersonalInfoUpdate(PersonalInfo.fldId, Employee.fldId, Employee_Detail.fldSh_Shenasname, Employee_Detail.fldTarikhTavalod, Employee_Detail.fldMahalTavalodId, Employee_Detail.fldMahalSodoorId, Employee_Detail.fldAddress, Employee_Detail.fldCodePosti, PersonalInfo.fldEsargariId, PersonalInfo.fldSharhEsargari
                        , PersonalInfo.fldSh_Personali, PersonalInfo.fldMadrakId, PersonalInfo.fldReshteId, PersonalInfo.fldNezamVazifeId, PersonalInfo.fldOrganPostId, PersonalInfo.fldRasteShoghli, PersonalInfo.fldReshteShoghli, PersonalInfo.fldTarikhEstekhdam, PersonalInfo.fldTabaghe, PersonalInfo.fldMeliyat, PersonalInfo.fldSh_MojavezEstekhdam
                        , PersonalInfo.fldTarikhMajavezEstekhdam, UserId, PersonalInfo.fldDesc, FileId, Image, Pasvand, PersonalInfo.fldName, PersonalInfo.fldFamily, PersonalInfo.fldFatherName, PersonalInfo.fldJensiyat, Employee.fldStatus, PersonalInfo.fldCodemeli, Employee_Detail.fldTaaholId, Employee_Detail.fldTarikhSodoor, PersonalInfo.fldOrganPostEjraeeId, PersonalInfo.fldTel, PersonalInfo.fldMobile);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Prs_tblPersonalInfoDelete(Id, UserId);
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
                var Personal = p.spr_Pay_tblPersonalInfoSelect("CheckPrs_PersonalInfoId", Id.ToString(),0, 1).FirstOrDefault();
                var a = p.spr_tblAfradTahtePoosheshSelect("CheckPersonalId", Id.ToString(),0, 1).FirstOrDefault();
                /*var h = p.spr_tblHistoryNoeEstekhdamSelect("CheckPrsPersonalInfoId", Id.ToString(),0, 1).FirstOrDefault();*/
                var personal_H = p.spr_tblPersonalHokmSelect("CheckPrs_PersonalInfoId", Id.ToString(),"",0,0, 1).FirstOrDefault();
                var s = p.spr_tblSavabegheSanavateKHedmatSelect("CheckPersonalId", Id.ToString(), "", "",0, 1).FirstOrDefault();
                var savabegh = p.spr_tblSavabeghGroupTashvighiSelect("CheckPersonalId", Id.ToString(),0, 1).FirstOrDefault();
                var S = p.spr_tblSavabeghJebhe_PersonalSelect("fldPrsPersonalId", Id.ToString(), "", 0).FirstOrDefault();
                if (Personal != null || a != null || personal_H != null || s != null || savabegh != null||S!=null)
                    q = true;
                return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Sh_Personali, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_Prs_tblPersonalInfoSelect("CheckSh_Personali", Sh_Personali.PadLeft(10,'0'), 0, 0).Any();

                }
                else
                {
                    var query = p.spr_Prs_tblPersonalInfoSelect("CheckSh_Personali", Sh_Personali.PadLeft(10, '0'), 0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region Select_Hokm
        public List<OBJ_PersonalInfo> Select_Hokm(string FieldName, string FilterValue, int OrganId,int UserId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Prs_tblPersonalInfoSelect_Hokm(FieldName, FilterValue, OrganId,UserId, h)
                    .Select(q => new OBJ_PersonalInfo()
                    {
                        fldId = q.fldId,
                        fldChartOrganId = q.fldChartOrganId,
                        fldEmployeeId = q.fldEmployeeId,
                        fldEsargariId = q.fldEsargariId,
                        fldNezamVazifeId = q.fldNezamVazifeId,
                        fldNameJensiyat = q.fldNameJensiyat,
                        fldAddress = q.fldAddress,
                        fldCodePosti = q.fldCodePosti,
                        fldVaziyatEsargariTitle = q.fldVaziyatEsargariTitle,
                        fldRasteShoghli = q.fldRasteShoghli,
                        fldReshteShoghli = q.fldReshteShoghli,
                        fldSh_MojavezEstekhdam = q.fldSh_MojavezEstekhdam,
                        fldSh_Personali = q.fldSh_Personali,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldTabaghe = q.fldTabaghe,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        fldTarikhMajavezEstekhdam = q.fldTarikhMajavezEstekhdam,
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        fldSharhEsargari = q.fldSharhEsargari,
                        fldMeliyatName = q.fldMeliyatName,
                        fldMadrakTahsiliTitle = q.fldMadrakTahsiliTitle,
                        fldNameEmployee = q.fldNameEmployee,
                        fldNameMahalTavalod = q.fldNameMahalTavalod,
                        fldNameMahlSodoor = q.fldNameMahlSodoor,
                        fldNameOrgan = q.fldNameOrgan,
                        fldNezamVazifeTitle = q.fldNezamVazifeTitle,
                        fldTitleChartOrgan = q.fldTitleChartOrgan,
                        fldCodemeli = q.fldCodemeli,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate,
                        fldOrganPostId = q.fldOrganPostId,
                        fldReshteTahsiliTitle = q.fldReshteTahsiliTitle,
                        NamePostOran = q.NamePostOran,
                        fldName_FamilyEmployee = q.fldName_FamilyEmployee,
                        fldOrganId = q.fldOrganId,
                        fldIdStatus = q.fldIdStatus,
                        fldNoeEstekhdam = q.fldNoeEstekhdam,
                        fldTitleStatus = q.fldTitleStatus,
                        fldJensiyat = q.fldJensiyat,
                        fldReshteId = q.fldReshteId,
                        fldMahalSodoorId = q.fldMahalSodoorId,
                        fldMahalTavalodId = q.fldMahalTavalodId,
                        fldMeliyat = q.fldMeliyat,
                        fldMadrakId = q.fldMadrakId,
                        fldTarikhSodoor = q.fldTarikhSodoor,
                        fldTaaholId = q.fldTaaholId,
                        TitleNoeEstekhdam = q.TitleNoeEstekhdam,
                        TitleOrganPostEjraee = q.TitleOrganPostEjraee,
                        TitleChartOrganEjraee = q.TitleChartOrganEjraee,
                        fldOrganPostEjraeeId = q.fldOrganPostEjraeeId,
                    }).ToList();
                return k;
            }
        }
        #endregion
      /*  #region CheckRepeatedRow
        public bool CheckRepeatedRow(int EmployeeId, int MahalTavalodId, int MahalSodoorId, int EsargariId, int MadrakId, int NezamVazifeId, int OrganPostId, int ChartOrganId, string Sh_Personali, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0 && EmployeeId==0)
                {
                    var q1 = p.spr_Prs_tblPersonalInfoSelect("fldOrganId", OrganPostId.ToString(), 0).Where(l => l.fldMahalTavalodId == MahalTavalodId && l.fldMahlSodoorId == MahalSodoorId
                        && l.fldEsargariId == EsargariId && l.fldMadrakId == MadrakId && l.fldNezamVazifeId == NezamVazifeId && l.fldChartOrganId == ChartOrganId).Any();
                    var q2 = p.spr_Prs_tblPersonalInfoSelect("fldSh_Personali", Sh_Personali.ToString(), 0).Any();
                    if (q1 == true || q2 == true)
                    {
                        q = true;
                    }
                }
                else
                {
                    var q1 = p.spr_Prs_tblPersonalInfoSelect("fldEmployeeId", EmployeeId.ToString(), 0).Where(l => l.fldMahalTavalodId == MahalTavalodId && l.fldMahlSodoorId == MahalSodoorId
                        && l.fldEsargariId == EsargariId && l.fldMadrakId == MadrakId && l.fldNezamVazifeId == NezamVazifeId && l.fldOrganPostId == OrganPostId && l.fldChartOrganId == ChartOrganId).FirstOrDefault();
                    var q2 = p.spr_Prs_tblPersonalInfoSelect("fldSh_Personali", Sh_Personali.ToString(), 0).FirstOrDefault();
                    if (q1 != null && q1.fldId != Id || q2 != null && q2.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion*/
    }
}