using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_Kala
    {
        #region Detail
        public OBJ_Kala Detail(int id,int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblKalaSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_Kala
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldArzeshAfzodeh = q.fldArzeshAfzodeh,
                        fldIranCode = q.fldIranCode,
                        fldName = q.fldName,
                        fldKalaCode = q.fldKalaCode,
                        fldKalaType = q.fldKalaType,
                        fldMoshakhase = q.fldMoshakhase,
                        fldMoshakhaseType = q.fldMoshakhaseType,
                        fldNesbatType = q.fldNesbatType,
                        fldSell = q.fldSell,
                        fldStatus = q.fldStatus,
                        fldVahedAsli = q.fldVahedAsli,
                        fldVahedFaree = q.fldVahedFaree,
                        fldVahedMoadel = q.fldVahedMoadel,
                        fldStatusName = q.fldStatusName,
                        fldVahedAsli_Name = q.fldVahedAsli_Name,
                        fldVahedFaree_Name = q.fldVahedFaree_Name
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Kala> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblKalaSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_Kala()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldArzeshAfzodeh = q.fldArzeshAfzodeh,
                        fldIranCode = q.fldIranCode,
                        fldName = q.fldName,
                        fldKalaCode = q.fldKalaCode,
                        fldKalaType = q.fldKalaType,
                        fldMoshakhase = q.fldMoshakhase,
                        fldMoshakhaseType = q.fldMoshakhaseType,
                        fldNesbatType = q.fldNesbatType,
                        fldSell = q.fldSell,
                        fldStatus = q.fldStatus,
                        fldVahedAsli = q.fldVahedAsli,
                        fldVahedFaree = q.fldVahedFaree,
                        fldVahedMoadel = q.fldVahedMoadel,
                        fldStatusName = q.fldStatusName,
                        fldVahedAsli_Name = q.fldVahedAsli_Name,
                        fldVahedFaree_Name = q.fldVahedFaree_Name
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, int UserId,int OrganId, string IP, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblKalaInsert(Name, KalaType, KalaCode, Status, Sell, ArzeshAfzodeh, IranCode, MoshakhaseType, Moshakhase, VahedAsli, VahedFaree, NesbatType, VahedMoadel, Desc, IP, UserId,OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, int UserId, int OrganId, string IP, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblKalaUpdate(Id, Name, KalaType, KalaCode, Status, Sell, ArzeshAfzodeh, IranCode, MoshakhaseType, Moshakhase, VahedAsli, VahedFaree, NesbatType, VahedMoadel, Desc, IP, UserId, OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblKalaDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int Id, string Name, string KalaCode,int OrganId)
        {
            var q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    var q1 = p.spr_tblKalaSelect("fldName", Name,OrganId, 0).Any();
                    var q2 = p.spr_tblKalaSelect("fldKalaCode", KalaCode,OrganId, 0).Any();
                    if (q1 == true || q2 == true)
                        q = true;
                }
                else
                {
                    var query = p.spr_tblKalaSelect("fldName", Name, OrganId, 0).FirstOrDefault();
                    var query1 = p.spr_tblKalaSelect("fldKalaCode", KalaCode, OrganId, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id || query1 != null && query1.fldId != Id)
                    {
                        q = true;
                    }
                }

            }
            return q;
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (WeighEntities p = new WeighEntities())
            {
                var Parametr = p.spr_tblRemittance_DetailsSelect("CheckKalaId", id.ToString(), 0, 0).FirstOrDefault();
                var Arze = p.spr_tblArzeSelect("fldKalaId", id.ToString(), 0, 0).FirstOrDefault();
                if (Parametr != null || Arze != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}