using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.Common
{
    public class DL_SHobe
    {
        #region Detail
        public OBJ_SHobe Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblSHobeSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_SHobe()
                    {
                        fldAddress = q.fldAddress,
                        fldBankId = q.fldBankId,
                        fldCodeSHobe = q.fldCodeSHobe,
                        fldName = q.fldName,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankName = q.fldBankName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SHobe> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblSHobeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_SHobe()
                    {
                        fldAddress = q.fldAddress,
                        fldBankId = q.fldBankId,
                        fldCodeSHobe = q.fldCodeSHobe,
                        fldName = q.fldName,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankName = q.fldBankName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int BankId, string Name, int CodeSHobe, string Address, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblSHobeInsert(BankId, Name, CodeSHobe, Address, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int BankId, string Name, int CodeSHobe, string Address, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblSHobeUpdate(Id, BankId,Name,CodeSHobe,Address, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblSHobeDelete(Id, UserId);
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
                var m = p.spr_tblDisketSelect("CheckShobeId", id.ToString(), 0).FirstOrDefault();
                if (m != null)
                    q = true;
               
            }
            using (RasaFMSCommonDBEntities x = new RasaFMSCommonDBEntities())
            {
                var s = x.spr_tblShomareHesabeOmoomiSelect("fldShobeId", id.ToString(),"","", 0).FirstOrDefault();
                if (s != null)
                    q = true;
            }
            using (ChekEntities m = new ChekEntities())
            {
                var chekvarede = m.spr_tblCheckHayeVaredeSelect("fldShobeId_CheckDelete", id.ToString(), 0, 0).FirstOrDefault();
                if (chekvarede != null)
                    q = true;
            }
            /*using (ContractEntities m = new ContractEntities())
            {
                var Registration = m.spr_tblRegistrationContractSelect("fldShobeId", id.ToString(), 0).FirstOrDefault();
                if (Registration != null)
                    q = true;
            }*/
             return q;
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name,int BankId, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblSHobeSelect("fldName", Name, 0).Where(l => l.fldBankId == BankId).Any();

                }
                else
                {
                    var query = p.spr_tblSHobeSelect("fldName", Name, 0).Where(l => l.fldBankId == BankId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}