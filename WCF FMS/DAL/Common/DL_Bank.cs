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
    public class DL_Bank
    {
        #region Detail
        public OBJ_Bank Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblBankSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Bank()
                    {
                        fldBankName = q.fldBankName,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFileId = q.fldFileId,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCentralBankCode = q.fldCentralBankCode,
                        fldInfinitiveBank = q.fldInfinitiveBank,
                        fldFix = q.fldFix,
                        fldFixTitle = q.fldFixTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Bank> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblBankSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Bank()
                    {
                        fldBankName = q.fldBankName,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFileId = q.fldFileId,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCentralBankCode = q.fldCentralBankCode,
                        fldInfinitiveBank = q.fldInfinitiveBank,
                        fldFix = q.fldFix,
                        fldFixTitle = q.fldFixTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string BankName, byte[] File, string Pasvand, byte? CentralBankCode,string InfinitiveBank,bool Fix, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblBankInsert(BankName, File, Pasvand, UserId, CentralBankCode, InfinitiveBank, Fix, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string BankName, int FileId, byte[] File, string Pasvand, byte? CentralBankCode, string InfinitiveBank, bool Fix, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblBankUpdate(Id, BankName, FileId, File, Pasvand, UserId, Desc, CentralBankCode, InfinitiveBank,Fix);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblBankDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                q = p.spr_tblSHobeSelect("fldBankId", id.ToString(), 0).Any();

            }
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var Pardakht_F = m.spr_tblPardakhtFileSelect("fldBankId", id.ToString(), 0).FirstOrDefault();
                if (Pardakht_F != null)
                    q = true;
            }
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var ShomareHesab = p.spr_tblShomareHesabPasAndazSelect("CheckBankId", id.ToString(), 0, 0).FirstOrDefault();
                var S = p.spr_tblShomareHesabsSelect("CheckBankId", id.ToString(), "", "", 0, 0).FirstOrDefault();
                var d = p.spr_tblDisketSelect("fldBankFixId", id.ToString(), 0).FirstOrDefault();
                var Setting = p.spr_tblSettingSelect("fldH_BankFixId", id.ToString(), 0, 0).FirstOrDefault();
                var Setting1 = p.spr_tblSettingSelect("fldB_BankFixId", id.ToString(), 0, 0).FirstOrDefault();
                if (ShomareHesab != null || S != null || d != null || Setting != null || Setting1 != null)
                    q = true;
            }
            using (ChekEntities p = new ChekEntities())
            {
                var Olgo_Ch = p.spr_tblOlgoCheckSelect("fldBankId_Check", id.ToString(),0, 0).FirstOrDefault();
                if (Olgo_Ch != null)
                    q = true;
            }
            return q;
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string BankName, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblBankSelect("fldBankName", BankName, 0).Any();

                }
                else
                {
                    var query = p.spr_tblBankSelect("fldBankName", BankName, 0).FirstOrDefault();
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