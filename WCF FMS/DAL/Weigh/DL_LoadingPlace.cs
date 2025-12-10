using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_LoadingPlace
    {
        #region Detail
        public OBJ_LoadingPlace Detail(int id)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var k = p.spr_tblLoadingPlaceSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_LoadingPlace
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldIP = q.fldIP,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LoadingPlace> Select(string FieldName, string FilterValue, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblLoadingPlaceSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_LoadingPlace()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldIP = q.fldIP,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblLoadingPlaceInsert( fldName,userId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblLoadingPlaceUpdate(fldId, fldName, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblLoadingPlaceDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name, int Id)
        {
            bool q = false;
            using (WeighEntities p = new WeighEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblLoadingPlaceSelect("fldName", Name, 0).Any();

                }
                else
                {
                    var query = p.spr_tblLoadingPlaceSelect("fldName", Name, 0).FirstOrDefault();
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