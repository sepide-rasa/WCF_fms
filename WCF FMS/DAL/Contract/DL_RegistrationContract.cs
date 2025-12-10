using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;
using WCF_FMS.TOL.Contract;

namespace WCF_FMS.DAL.Contract
{
    public class DL_RegistrationContract
    {
        #region Detail
        public OBJ_RegistrationContract Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblRegistrationContractSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_RegistrationContract
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldAmountContract = q.fldAmountContract,
                        fldAshkhasId = q.fldAshkhasId,
                        fldEndContract = q.fldEndContract,
                        fldNumber = q.fldNumber,
                        fldRoleOrgan = q.fldRoleOrgan,
                        fldSepamNum = q.fldSepamNum,
                        fldShobeId = q.fldShobeId,
                        fldStartContract = q.fldStartContract,
                        fldSuplyMaterialsType = q.fldSuplyMaterialsType,
                        fldTarikh = q.fldTarikh,
                        fldTarikhEtmam = q.fldTarikhEtmam,
                        fldTitleContract = q.fldTitleContract,
                        fldWarrantyId = q.fldWarrantyId,
                        fldCodeMelli = q.fldCodeMelli,
                        fldName_Shakhs = q.fldName_Shakhs,
                        fldName_Shobe = q.fldName_Shobe,
                        fldCodeSHobe = q.fldCodeSHobe,
                        fldRoleOrgan_Name = q.fldRoleOrgan_Name,
                        fldSuplyMaterialsType_Name = q.fldSuplyMaterialsType_Name,
                        fldBankId = q.fldBankId,
                        fldBankName = q.fldBankName,
                        fldWarentytype_Name = q.fldWarentytype_Name,
                        fldOrganId = q.fldOrganId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_RegistrationContract> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblRegistrationContractSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_RegistrationContract()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldAmountContract = q.fldAmountContract,
                        fldAshkhasId = q.fldAshkhasId,
                        fldEndContract = q.fldEndContract,
                        fldNumber = q.fldNumber,
                        fldRoleOrgan = q.fldRoleOrgan,
                        fldSepamNum = q.fldSepamNum,
                        fldShobeId = q.fldShobeId,
                        fldStartContract = q.fldStartContract,
                        fldSuplyMaterialsType = q.fldSuplyMaterialsType,
                        fldTarikh = q.fldTarikh,
                        fldTarikhEtmam = q.fldTarikhEtmam,
                        fldTitleContract = q.fldTitleContract,
                        fldWarrantyId = q.fldWarrantyId,
                        fldCodeMelli = q.fldCodeMelli,
                        fldName_Shakhs = q.fldName_Shakhs,
                        fldName_Shobe = q.fldName_Shobe,
                        fldCodeSHobe = q.fldCodeSHobe,
                        fldRoleOrgan_Name = q.fldRoleOrgan_Name,
                        fldSuplyMaterialsType_Name = q.fldSuplyMaterialsType_Name,
                        fldBankId = q.fldBankId,
                        fldBankName = q.fldBankName,
                        fldWarentytype_Name = q.fldWarentytype_Name,
                        fldOrganId = q.fldOrganId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int WarrantyId, byte RoleOrgan, string TitleContract,int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam,string StartContract, string EndContract,int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblRegistrationContractInsert(WarrantyId, RoleOrgan, TitleContract, AshkhasId, SuplyMaterialsType, AmountContract, Number, Tarikh, ShobeId, SepamNum, TarikhEtmam, StartContract, EndContract, Desc, IP, UserId, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int WarrantyId, byte RoleOrgan, string TitleContract, int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam, string StartContract, string EndContract, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblRegistrationContractUpdate(Id, WarrantyId, RoleOrgan, TitleContract, AshkhasId, SuplyMaterialsType, AmountContract, Number, Tarikh, ShobeId, SepamNum, TarikhEtmam, StartContract, EndContract, Desc, IP, UserId,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblRegistrationContractDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}