using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_GeneralSetting
    {
        #region Detail
        public OBJ_GeneralSetting Detail(int Id, int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblGeneralSettingSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_GeneralSetting()
                    {
                        fldValue = q.fldValue,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldModuleId = q.fldModuleId,
                        fldNameModule = q.fldNameModule,
                        fldTitleCombo = q.fldTitleCombo
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_GeneralSetting> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblGeneralSettingSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_GeneralSetting()
                    {
                        fldValue = q.fldValue,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldModuleId = q.fldModuleId,
                        fldNameModule = q.fldNameModule,
                        fldTitleCombo = q.fldTitleCombo
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(string fldName, string fldValue, int fldOrganId, int fldModuleId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblGeneralSettingInsert(Id,fldName, fldValue, UserId, Desc, fldOrganId, fldModuleId);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(byte Id, string fldName, string fldValue, int fldOrganId, int fldModuleId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSettingUpdate(Id, fldName, fldValue, UserId, Desc, fldOrganId, fldModuleId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSettingDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region GeneralSettingInsert
        public string GeneralSettingInsert(string fldName, string fldValue, int fldOrganId, int fldModuleId, System.Data.DataTable ComboBox, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_GeneralSettingInsert( fldName, fldValue, UserId, Desc, fldOrganId, fldModuleId,ComboBox);
                return "دخیره با موفقیت انجام شد";
            }
        }
        #endregion

        #region GeneralSettingUpdate
        public string GeneralSettingUpdate(int fldHeaderId, string fldName, string fldValue, int fldOrganId, int fldModuleId, System.Data.DataTable ComboBox, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_GeneralSettingUpdate(fldHeaderId, fldName, fldValue, UserId, Desc, fldOrganId, fldModuleId, ComboBox);
                return "دخیره با موفقیت انجام شد";
            }
        }
        #endregion
        #region GeneralSettingDelete
        public string GeneralSettingDelete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_GeneralSettingDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}