using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_KosorateParametri_Personal
    {
        #region Detail
        public OBJ_KosorateParametri_Personal Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKosorateParametri_PersonalSelect("fldId", Id.ToString(), "", "", "", OrganId, 1)
                    .Select(q => new OBJ_KosorateParametri_Personal()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodemeli=q.fldCodemeli,
                        fldDateDeactive=q.fldDateDeactive,
                        fldMablagh=q.fldMablagh,
                        fldMondeFish=q.fldMondeFish,
                        fldMondeGHabl=q.fldMondeGHabl,
                        fldName_Father=q.fldName_Father,
                        fldNoePardakht=q.fldNoePardakht,
                        fldNoePardakhtName=q.fldNoePardakhtName,
                        fldParametrId=q.fldParametrId,
                        fldParamTitle=q.fldParamTitle,
                        fldPersonalId=q.fldPersonalId,
                        fldSh_Personali=q.fldSh_Personali,
                        fldStatus=q.fldStatus,
                        fldstatusName=q.fldstatusName,
                        fldSumFish=q.fldSumFish,
                        fldSumPardakhtiGHabl=q.fldSumPardakhtiGHabl,
                        fldTarikhePardakht = q.fldTarikhePardakht,
                        fldTedad = q.fldTedad
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_KosorateParametri_Personal> Select(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3,int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKosorateParametri_PersonalSelect(FieldName, FilterValue, FilterValue1, FilterValue2, FilterValue3, OrganId, h)
                    .Select(q => new OBJ_KosorateParametri_Personal()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodemeli = q.fldCodemeli,
                        fldDateDeactive = q.fldDateDeactive,
                        fldMablagh = q.fldMablagh,
                        fldMondeFish = q.fldMondeFish,
                        fldMondeGHabl = q.fldMondeGHabl,
                        fldName_Father = q.fldName_Father,
                        fldNoePardakht = q.fldNoePardakht,
                        fldNoePardakhtName = q.fldNoePardakhtName,
                        fldParametrId = q.fldParametrId,
                        fldParamTitle = q.fldParamTitle,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldStatus = q.fldStatus,
                        fldstatusName = q.fldstatusName,
                        fldSumFish = q.fldSumFish,
                        fldSumPardakhtiGHabl = q.fldSumPardakhtiGHabl,
                        fldTarikhePardakht = q.fldTarikhePardakht,
                        fldTedad = q.fldTedad
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status,int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKosorateParametri_PersonalInsert(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhePardakht, SumFish, MondeFish, SumPardakhtiGHabl
                    , MondeGHabl, Status, DateDeactive, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertGroup
        public string InsertGroup(string PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
               var q= p.spr_tblKosorateParametri_PersonalGroupInsert(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhePardakht, SumFish, MondeFish, SumPardakhtiGHabl
                    , MondeGHabl, Status, DateDeactive, UserId, Desc);
                return q.FirstOrDefault().fldName;
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKosorateParametri_PersonalUpdate(Id, PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhePardakht, SumFish, MondeFish, SumPardakhtiGHabl
                    , MondeGHabl, Status, DateDeactive, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKosorateParametri_PersonalDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
         #region UpdateDeactive
        public string UpdateDeactive(string PersonalId, int ParametrId, int Mablagh, string TarikhePardakht, 
             bool Status, int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKosorateParametriDeactive_PersonalUpdate( PersonalId, ParametrId,  Mablagh,  TarikhePardakht,  Status, DateDeactive, UserId,  Desc);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PersonalId, int ParametrId, int Mablagh, string TarikhePardakht, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblKosorateParametri_PersonalSelect("CheckPersonal", PersonalId.ToString(), ParametrId.ToString(), Mablagh.ToString(), TarikhePardakht,0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblKosorateParametri_PersonalSelect("CheckPersonal", PersonalId.ToString(), ParametrId.ToString(), Mablagh.ToString(), TarikhePardakht,0, 0).FirstOrDefault();
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
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var m = p.spr_tblMohasebat_kosorat_MotalebatParamSelect("fldKosoratId", Id.ToString(), 1).FirstOrDefault();
                var Tavigh = p.spr_tblTavighKosuratSelect("fldKosuratId", Id.ToString(), 0).FirstOrDefault();
                if (m != null || Tavigh != null)
                    q = true;
                return q;
            }
        }
        #endregion
        #region UpdateKosurat_Motalebat
        public string UpdateKosurat_Motalebat(string FieldName, bool Status, int id, int dateActive,int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Pay_UpdateKosurat_Motalebat(FieldName, Status, id, dateActive, UserId);
                return "تغییر وضعیت با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}