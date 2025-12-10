using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Check
    {
        #region Detail
        public OBJ_Check Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCheckSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Check()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMablaghSanad = (long)q.fldMablaghSanad,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldStatusName = q.fldStatusName,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesab=q.fldShomareHesab,
                        fldShomareHesabOrgan=q.fldShomareHesabOrgan
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region UpdateSendToMali_Check
        public string UpdateSendToMali_Check(int id, bool Flag)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateSendToMali_Check(id, Flag);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateReceive_Check
        public string UpdateReceive_Check(int CheckId, int UserId,int Document_HeaderId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.prs_UpdateReceive_Check(CheckId, UserId, Document_HeaderId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertCheckIntoSanad
        public string InsertCheckIntoSanad(int CheckId,string DocDate, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var q = p.prs_InsertCheckIntoSanad(CheckId, UserId, DocDate).FirstOrDefault();
                if (q.fldId != 0)
                {
                    return q.fldId.ToString();
                }
                else
                {
                    return q.ErrorMessage;
                }
            }
        }
        #endregion
        #region Select
        public List<OBJ_Check> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCheckSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Check()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMablaghSanad =(long) q.fldMablaghSanad,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldStatusName = q.fldStatusName,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabOrgan = q.fldShomareHesabOrgan
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(out int fldId,int ShomareHesabId, string ShomareSanad, int ReplyTaghsitId, string TarikhSarResid, long MablaghSanad, byte Status, bool TypeSanad, int ShomareHesabIdOrgan, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldid", typeof(int));
                p.spr_tblCheckInsert(id,ShomareHesabId, ShomareSanad, ReplyTaghsitId, TarikhSarResid, MablaghSanad, Status, TypeSanad, UserId, Desc,ShomareHesabIdOrgan);
                fldId = Convert.ToInt16(id.Value);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabId, string ShomareSanad, int ReplyTaghsitId, string TarikhSarResid, long MablaghSanad, byte Status, bool TypeSanad, int ShomareHesabIdOrgan, string DateStatus, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCheckUpdate(Id,ShomareHesabId,ShomareSanad,ReplyTaghsitId,TarikhSarResid,MablaghSanad,Status,TypeSanad, UserId, Desc,ShomareHesabIdOrgan,DateStatus);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCheckDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int id,string ShomareSanad)
        {
            var b = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (id == 0)
                    b = p.spr_tblCheckSelect("fldShomareSanad", ShomareSanad.ToString(), 0).Any();
                 else
                 {
                    var t = p.spr_tblCheckSelect("fldShomareSanad", ShomareSanad.ToString(), 0).FirstOrDefault();
                    if (t != null && t.fldId != id)
                        b = true;       
                 }
                return b;
            }
        }
        #endregion
    }
}