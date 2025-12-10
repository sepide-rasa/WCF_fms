using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_GeneralSetting_Value
    {
        #region Detail
        public OBJ_GeneralSetting_Value Detail(int Id, int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblGeneralSetting_ValueSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_GeneralSetting_Value()
                    {
                        fldValue = q.fldValue,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldGeneralSettingId = q.fldGeneralSettingId,
                        fldOrganId = q.fldOrganId,
                        fldNameGeneralSetting = q.fldNameGeneralSetting,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_GeneralSetting_Value> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblGeneralSetting_ValueSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_GeneralSetting_Value()
                    {
                        fldValue = q.fldValue,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldGeneralSettingId = q.fldGeneralSettingId,
                        fldOrganId = q.fldOrganId,
                        fldNameGeneralSetting = q.fldNameGeneralSetting,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(byte fldGeneralSettingId, string fldValue, int UserId, int fldOrganId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSetting_ValueInsert(fldGeneralSettingId, fldValue, UserId, Desc, fldOrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(byte Id, byte fldGeneralSettingId, string fldValue, int UserId, int fldOrganId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSetting_ValueUpdate(Id, fldGeneralSettingId, fldValue, UserId, Desc, fldOrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSetting_ValueDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}