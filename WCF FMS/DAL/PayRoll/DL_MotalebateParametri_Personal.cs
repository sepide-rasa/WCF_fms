using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MotalebateParametri_Personal
    {
        #region Detail
        public OBJ_MotalebateParametri_Personal Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMotalebateParametri_PersonalSelect("fldId", Id.ToString(), "", "", "", OrganId, 1)
                    .Select(q => new OBJ_MotalebateParametri_Personal()
                    {
                        fldCodemeli = q.fldCodemeli,
                        fldDate = q.fldDate,
                        fldDateDeactive = q.fldDateDeactive,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldMablagh = q.fldMablagh,
                        fldMashmoleBime = q.fldMashmoleBime,
                        fldMashmoleBimeName = q.fldMashmoleBimeName,
                        fldMashmoleMaliyat = q.fldMashmoleMaliyat,
                        fldMashmoleMaliytName = q.fldMashmoleMaliytName,
                        fldName_Father = q.fldName_Father,
                        fldNoePardakht = q.fldNoePardakht,
                        fldNoePardakhtName = q.fldNoePardakhtName,
                        fldParametrId = q.fldParametrId,
                        fldParamTitle = q.fldParamTitle,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhPardakht = q.fldTarikhPardakht,
                        fldTedad = q.fldTedad,
                        fldUserId = q.fldUserId,
                        fldMazayaMashmool = Convert.ToBoolean(q.fldMazayaMashmool),
                        fldMazayaMashmoolName = q.fldMazayaMashmoolName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MotalebateParametri_Personal> Select(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMotalebateParametri_PersonalSelect(FieldName, FilterValue, FilterValue1, FilterValue2, FilterValue3, OrganId, h)
                    .Select(q => new OBJ_MotalebateParametri_Personal()
                    {
                        fldCodemeli = q.fldCodemeli,
                        fldDate = q.fldDate,
                        fldDateDeactive = q.fldDateDeactive,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldMablagh = q.fldMablagh,
                        fldMashmoleBime = q.fldMashmoleBime,
                        fldMashmoleBimeName = q.fldMashmoleBimeName,
                        fldMashmoleMaliyat = q.fldMashmoleMaliyat,
                        fldMashmoleMaliytName = q.fldMashmoleMaliytName,
                        fldName_Father = q.fldName_Father,
                        fldNoePardakht = q.fldNoePardakht,
                        fldNoePardakhtName = q.fldNoePardakhtName,
                        fldParametrId = q.fldParametrId,
                        fldParamTitle = q.fldParamTitle,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhPardakht = q.fldTarikhPardakht,
                        fldTedad = q.fldTedad,
                        fldUserId = q.fldUserId,
                        fldMazayaMashmool=Convert.ToBoolean(q.fldMazayaMashmool),
                        fldMazayaMashmoolName=q.fldMazayaMashmoolName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMotalebateParametri_PersonalInsert(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime, fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertGroup
        public string InsertGroup(string PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var q = p.spr_tblMotalebateParametri_PersonalGroupInsert(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime, fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc);
                return q.FirstOrDefault().fldName;
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMotalebateParametri_PersonalUpdate(Id, PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime, fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

         #region UpdateDeactive
        public string UpdateDeactive(string PersonalId, int ParametrId, int Mablagh, string TarikhePardakht, 
             bool Status, int DateDeactive, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMotalebateParametriDeactive_PersonalUpdate(PersonalId, ParametrId, Mablagh, TarikhePardakht, Status, DateDeactive, UserId, Desc);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMotalebateParametri_PersonalDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var Mohasebat = p.spr_tblMohasebat_kosorat_MotalebatParamSelect("fldMotalebatId", Id.ToString(), 0).FirstOrDefault();
                if (Mohasebat != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}