using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.DAL.Chek
{
    public class DL_AghsatCheckAmani
    {
        #region Detail
        public OBJ_AghsatCheckAmani Detail(int Id,int OrganId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblAghsatCheckAmaniSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_AghsatCheckAmani()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldIdCheckHayeVarede = q.fldIdCheckHayeVarede,
                        fldMablagh = q.fldMablagh,
                        fldNobat = q.fldNobat,
                        fldTarikh = q.fldTarikh,
                        fldVaziat = q.fldvaziat,
                        NameVaziat = q.NameVaziat,
                        fldTarikhVaziat = q.fldTarikhVaziat,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AghsatCheckAmani> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblAghsatCheckAmaniSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_AghsatCheckAmani()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldIdCheckHayeVarede = q.fldIdCheckHayeVarede,
                        fldMablagh = q.fldMablagh,
                        fldNobat = q.fldNobat,
                        fldTarikh = q.fldTarikh,
                        fldTarikhVaziat = q.fldTarikhVaziat,
                        fldVaziat = q.fldvaziat,
                        NameVaziat = q.NameVaziat,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long Mablagh, string Tarikh, string Nobat, int CheckHayeVaredeId,int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblAghsatCheckAmaniInsert(Mablagh, Tarikh, Nobat, CheckHayeVaredeId, UserId, Desc,OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long Mablagh, string Tarikh, string Nobat, int CheckHayeVaredeId, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblAghsatCheckAmaniUpdate(Id, Mablagh, Tarikh, Nobat, CheckHayeVaredeId, UserId, Desc,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblAghsatCheckAmaniDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateStatusAghsat
        public string UpdateStatusAghsat(int Id, string TarikhPardakht, byte Vaziat, int UserId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_UpdateStatusAghsatCheckAmani(Id, TarikhPardakht, Vaziat, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion

        #region Delete_CheckHayeVaredeId
        public string Delete_CheckHayeVaredeId(int ChekVardeId, int UserId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_AghsatCheckAmaniDelete_CheckHayeVaredeId(ChekVardeId, UserId);
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
                var Status = m.spr_tblCheckStatusSelect("fldAghsatId", id.ToString(), 0).FirstOrDefault();
                if (Status != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}