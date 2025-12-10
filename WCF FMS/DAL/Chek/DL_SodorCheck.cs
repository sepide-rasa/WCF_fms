using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.DAL.Chek
{
    public class DL_SodorCheck
    {
        #region Detail
        public OBJ_SodorCheck Detail(int Id, int OrganId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblSodorCheckSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_SodorCheck()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldBankName = q.fldBankName,
                        fldBabat = q.fldBabat,
                        fldBabatFlag = q.fldBabatFlag,
                        fldCodeSerialCheck = q.fldCodeSerialCheck,
                        fldDarVajh = q.fldDarVajh,
                        fldIdDasteCheck = q.fldIdDasteCheck,
                        fldMablagh = q.fldMablagh,
                        fldMoshakhaseDasteCheck = q.fldMoshakhaseDasteCheck,
                        NameShobe = q.NameShobe,
                        fldTarikhVosol = q.fldTarikhVosol,
                        Name_Family = q.Name_Family,
                        TarikhSabt = q.TarikhSabt,
                        ShomareMeli = q.ShomareMeli,
                        fldShomareHesab = q.fldShomareHesab,
                        AshkhasId = q.AshkhasId,
                        BabatText = q.BabatText,
                        TarikhShamsi = q.TarikhShamsi,
                        MablaghBeHorof = q.MablaghBeHorof,
                        fldvaziat = q.fldvaziat,
                        NameVaziat = q.NameVaziat,
                        fldTarikhVaziat = q.fldTarikhVaziat,
                        fldOrganId = q.fldOrganId,
                        fldContractId=q.fldContractId,
                        fldFactorId=q.fldFactorId,
                        fldTankhahGroupId=q.fldTankhahGroupId,
                        Check_FactorId=q.Check_FactorId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SodorCheck> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblSodorCheckSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_SodorCheck()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldBankName = q.fldBankName,
                        fldBabat = q.fldBabat,
                        fldBabatFlag = q.fldBabatFlag,
                        fldCodeSerialCheck = q.fldCodeSerialCheck,
                        fldDarVajh = q.fldDarVajh,
                        fldIdDasteCheck = q.fldIdDasteCheck,
                        fldMablagh = q.fldMablagh,
                        fldMoshakhaseDasteCheck = q.fldMoshakhaseDasteCheck,
                        NameShobe = q.NameShobe,
                        fldTarikhVosol = q.fldTarikhVosol,
                        Name_Family = q.Name_Family,
                        TarikhSabt = q.TarikhSabt,
                        ShomareMeli = q.ShomareMeli,
                        fldShomareHesab = q.fldShomareHesab,
                        AshkhasId = q.AshkhasId,
                        BabatText = q.BabatText,
                        TarikhShamsi = q.TarikhShamsi,
                        MablaghBeHorof = q.MablaghBeHorof,
                        fldvaziat = q.fldvaziat,
                        NameVaziat = q.NameVaziat,
                        fldTarikhVaziat = q.fldTarikhVaziat,
                        fldOrganId = q.fldOrganId,
                        fldContractId = q.fldContractId,
                        fldFactorId = q.fldFactorId,
                        fldTankhahGroupId = q.fldTankhahGroupId,
                        Check_FactorId = q.Check_FactorId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectSumMablaghCheck_Factor
        public long SelectSumMablaghCheck_Factor(string FieldName, string FilterValue)
        {
            long fldMablagh = 0;
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_SelectSumCheckSadere(FieldName, FilterValue).FirstOrDefault();
                if(k!=null)
                    fldMablagh= Convert.ToInt64( k.fldMablagh);
            }
            return fldMablagh;
        }
        #endregion
        #region Insert
        public string Insert(int DasteCheckId, string TarikhVosol, int AshkhasId, string CodeSerialCheck, string Babat, bool BabatFlag, long Mablagh,int? FactorId,int? ContractId,
            int? TankhahGroupId, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter fldID = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblSodorCheckInsert(fldID,DasteCheckId, TarikhVosol, AshkhasId, CodeSerialCheck, Babat, BabatFlag, Mablagh, FactorId, ContractId, TankhahGroupId, Desc, UserId, OrganId);
                return fldID.Value.ToString();
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int DasteCheckId, string TarikhVosol, int AshkhasId, string CodeSerialCheck, string Babat, bool BabatFlag, long Mablagh,int? FactorId,int? ContractId,
            int? TankhahGroupId,int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblSodorCheckUpdate(Id, DasteCheckId, TarikhVosol, AshkhasId, CodeSerialCheck, Babat, BabatFlag, Mablagh,FactorId,ContractId,TankhahGroupId, Desc, UserId,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblSodorCheckDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (ChekEntities m = new ChekEntities())
            {
                var Status = m.spr_tblCheckStatusSelect("fldSodorCheckId", id.ToString(), 0).FirstOrDefault();
                if (Status != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}