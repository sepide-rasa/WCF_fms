using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_Arze
    {
        #region Detail
        public OBJ_Arze Detail(int id)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var k = p.spr_tblArzeSelect("fldId", id.ToString(),0, 1)
                    .Select(q => new OBJ_Arze
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldBaskoolId = q.fldBaskoolId,
                        fldIP = q.fldIP,
                        fldKalaId = q.fldKalaId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldOrganId = q.fldOrganId,
                        fldNameKala = q.fldNameKala,
                        fldDaramadCode = q.fldDaramadCode,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldTedad = q.fldTedad,
                        fldMablagh = q.fldMablagh,
                        fldOrganName = q.fldOrganName,
                        fldStatusForoosh=q.fldStatusForoosh,
                        fldStatusForooshName = q.fldStatusForooshName,
                        fldVaznVahed = q.fldVaznVahed
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Arze> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblArzeSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_Arze()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldBaskoolId = q.fldBaskoolId,
                        fldIP = q.fldIP,
                        fldKalaId = q.fldKalaId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldOrganId = q.fldOrganId,
                        fldNameKala = q.fldNameKala,
                        fldDaramadCode = q.fldDaramadCode,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldTedad = q.fldTedad,
                        fldMablagh = q.fldMablagh,
                        fldOrganName = q.fldOrganName,
                        fldStatusForoosh = q.fldStatusForoosh,
                        fldStatusForooshName = q.fldStatusForooshName,
                        fldVaznVahed=q.fldVaznVahed
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public int Insert(int fldBaskoolId, int fldKalaId, int ShomareHesabCodeDaramadId,byte Tedad,long Mablagh, int OrganizationId,byte Type,int? fldVaznVahed, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblArzeInsert(Id, fldBaskoolId, fldKalaId, ShomareHesabCodeDaramadId, Tedad,Mablagh,Type,fldVaznVahed, userId, OrganizationId, Desc, IP);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldBaskoolId, int fldKalaId, int ShomareHesabCodeDaramadId, byte Tedad, long Mablagh, int OrganizationId, byte Type,int? fldVaznVahed,int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblArzeUpdate(fldId, fldBaskoolId, fldKalaId, ShomareHesabCodeDaramadId, Tedad, Mablagh,Type,fldVaznVahed, userId, OrganizationId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblArzeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region SelectArze_Kala
        public List<OBJ_Arze_Kala> SelectArze_Kala(int BaskoolId, int OrganId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_SelectArze_Kala(BaskoolId, OrganId)
                    .Select(q => new OBJ_Arze_Kala()
                    {
                        fldId = q.fldId,
                        fldKalaId = q.fldKalaId,
                        fldCodeDaramadId = q.fldCodeDaramadId,
                        fldParametrSabetDaramadId = q.fldParametrSabetDaramadId,
                        fldSharheCodeDaramad = q.fldSharheCodeDaramad,
                        fldNameParametreFa = q.fldNameParametreFa,
                        fldNameWeighbridge = q.fldNameWeighbridge,
                        fldKalaName = q.fldKalaName,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}