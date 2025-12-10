using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_GeneralSetting_ComboBox
    {
        #region Detail
        public OBJ_GeneralSetting_ComboBox Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblGeneralSetting_ComboBoxSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_GeneralSetting_ComboBox()
                    {
                        fldValue = q.fldValue,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldGeneralSettingId = q.fldGeneralSettingId,
                        fldTtile = q.fldTtile,
                        fldNameGeneralSetting = q.fldNameGeneralSetting,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_GeneralSetting_ComboBox> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblGeneralSetting_ComboBoxSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_GeneralSetting_ComboBox()
                    {
                        fldValue = q.fldValue,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldGeneralSettingId = q.fldGeneralSettingId,
                        fldTtile = q.fldTtile,
                        fldNameGeneralSetting = q.fldNameGeneralSetting,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(byte fldGeneralSettingId, string fldTtile, string fldValue, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSetting_ComboBoxInsert(fldGeneralSettingId, fldTtile, fldValue, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(byte Id, byte fldGeneralSettingId, string fldTtile, string fldValue, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSetting_ComboBoxUpdate(Id, fldGeneralSettingId, fldTtile, fldValue, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblGeneralSetting_ComboBoxDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}