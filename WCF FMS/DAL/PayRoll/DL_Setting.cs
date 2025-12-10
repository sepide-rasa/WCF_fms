using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Setting
    {
        #region Update
        public string Update(int Id, int? H_BankFixId, string H_NameShobe, string H_CodeOrgan, string H_CodeShobe, bool ShowBankLogo, int OrganId, string CodeEghtesadi, int? Prs_PersonalId, string CodeParvande, string CodeOrganPasAndaz, int? Sh_HesabCheckId, int? B_BankFixId, string B_NameShobe, int? B_ShomareHesabId, string B_CodeShenasaee, string CodeDastgah, int? P_BankFixId, int P_ShobeId, int UserId, string Desc,byte StatusMahalKedmatId )
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSettingUpdate(Id, H_BankFixId, H_NameShobe, H_CodeOrgan, H_CodeShobe, ShowBankLogo, OrganId, CodeEghtesadi, Prs_PersonalId, CodeParvande, CodeOrganPasAndaz, Sh_HesabCheckId, B_BankFixId, B_NameShobe, B_ShomareHesabId, B_CodeShenasaee, CodeDastgah, UserId, Desc, P_BankFixId, P_ShobeId,StatusMahalKedmatId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Select
        public List<OBJ_Setting> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSettingSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Setting()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldB_BankFixId = q.fldB_BankFixId,
                        fldB_CodeShenasaee = q.fldB_CodeShenasaee,
                        fldB_NameShobe = q.fldB_NameShobe,
                        fldB_ShomareHesab = q.fldB_ShomareHesab,
                        fldBankName = q.fldBankName,
                        fldCodeEghtesadi = q.fldCodeEghtesadi,
                        fldCodemeli = q.fldCodemeli,
                        fldCodeOrganPasAndaz = q.fldCodeOrganPasAndaz,
                        fldCodeParvande = q.fldCodeParvande,
                        fldFamily = q.fldFamily,
                        fldH_BankFixId = q.fldH_BankFixId,
                        fldH_CodeOrgan = q.fldH_CodeOrgan,
                        fldH_CodeShobe = q.fldH_CodeShobe,
                        fldH_NameShobe = q.fldH_NameShobe,
                        fldImage = q.fldImage,
                        fldName = q.fldName,
                        fldOrganId = q.fldOrganId,
                        fldPostOrganName = q.fldPostOrganName,
                        fldPrs_PersonalId = q.fldPrs_PersonalId,
                        fldSh_HesabCheck = q.fldSh_HesabCheck,
                        fldShowBankLogo =Convert.ToBoolean( q.fldShowBankLogo),
                        fldCodeDastgah = q.fldCodeDastgah,
                        fldSh_HesabCheckId = q.fldSh_HesabCheckId,
                        fldB_ShomareHesabId = q.fldB_ShomareHesabId,
                        NameBankHoghoogh = q.NameBankHoghoogh,
                        fldP_BankFixName = q.fldP_BankFixName,
                        fldP_NameShobe = q.fldP_NameShobe,
                        fldP_BankFixId = q.fldP_BankFixId,
                        fldP_ShobeFixId=q.fldP_ShobeFixId,
                        fldStatusMahalKedmatId = q.fldStatusMahalKedmatId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}