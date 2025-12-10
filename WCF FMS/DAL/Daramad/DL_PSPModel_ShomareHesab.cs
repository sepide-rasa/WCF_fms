using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PSPModel_ShomareHesab
    {
        #region Detail
        public OBJ_PSPModel_ShomareHesab Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPSPModel_ShomareHesabSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PSPModel_ShomareHesab()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrder = q.fldOrder,
                        fldPSPModelId = q.fldPSPModelId,
                        fldShHesabId = q.fldShHesabId,
                        fldShomareHesab = q.fldShomareHesab
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PSPModel_ShomareHesab> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPSPModel_ShomareHesabSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PSPModel_ShomareHesab()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrder = q.fldOrder,
                        fldPSPModelId = q.fldPSPModelId,
                        fldShHesabId = q.fldShHesabId,
                        fldShomareHesab = q.fldShomareHesab
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PSPModelId, int ShHesabId, byte Order, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPSPModel_ShomareHesabInsert(PSPModelId, ShHesabId, Order, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PSPModelId, int ShHesabId, byte Order, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPSPModel_ShomareHesabUpdate(Id, PSPModelId, ShHesabId, Order, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPSPModel_ShomareHesabDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}