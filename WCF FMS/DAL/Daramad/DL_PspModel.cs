using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PspModel
    {
        #region Detail
        public OBJ_PspModel Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPspModelSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PspModel()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldModel=q.fldModel,
                        fldPspId = q.fldPspId,
                        fldTitle = q.fldTitle,
                        fldTitleModel = q.fldTitleModel,
                        fldMultiHesab = q.fldMultiHesab,
                        fldMultiHesabName = q.fldMultiHesabName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PspModel> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPspModelSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PspModel()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldModel = q.fldModel,
                        fldPspId = q.fldPspId,
                        fldTitle = q.fldTitle,
                        fldTitleModel = q.fldTitleModel,
                        fldMultiHesab = q.fldMultiHesab,
                        fldMultiHesabName = q.fldMultiHesabName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PspId, string Model,bool MultiHesab, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPspModelInsert(PspId, Model,MultiHesab, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PspId, string Model, bool MultiHesab, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPspModelUpdate(Id, PspId, Model, MultiHesab, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPspModelDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PspId, string Model, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblPspModelSelect("fldModel", Model, 0).Where(l => l.fldPspId == PspId).Any();

                }
                else
                {
                    var query = p.spr_tblPspModelSelect("fldModel", Model, 0).Where(l => l.fldPspId == PspId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
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
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var PspM = p.spr_tblPSPModel_ShomareHesabSelect("fldPSPModelId", id.ToString(), 0).FirstOrDefault();
                if (PspM != null)
                    q = true;
            }
            return q;
        }
        #endregion

    }
}