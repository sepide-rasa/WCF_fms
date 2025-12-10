using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_DaramadGroup_Parametr
    {
        #region Detail
        public OBJ_DaramadGroup_Parametr Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblDaramadGroup_ParametrSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_DaramadGroup_Parametr()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDaramadGroupId = q.fldDaramadGroupId,
                        fldEnName = q.fldEnName,
                        fldFnName = q.fldFnName,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldComboBoxId = q.fldComboBoxId,
                        fldFormuleId = q.fldFormuleId,
                        fldNoeField = q.fldNoeField,
                        NoeFieldName = q.NoeFieldName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DaramadGroup_Parametr> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblDaramadGroup_ParametrSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DaramadGroup_Parametr()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDaramadGroupId = q.fldDaramadGroupId,
                        fldEnName = q.fldEnName,
                        fldFnName = q.fldFnName,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldComboBoxId = q.fldComboBoxId,
                        fldFormuleId = q.fldFormuleId,
                        fldNoeField = q.fldNoeField,
                        NoeFieldName = q.NoeFieldName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int DaramadGroupId, string EnName, string FnName, bool Status,byte NoeField,int? ComboBoxId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroup_ParametrInsert(DaramadGroupId, EnName, FnName, Status, UserId, Desc, NoeField, ComboBoxId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int DaramadGroupId, string EnName, string FnName, bool Status, byte NoeField, int? ComboBoxId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroup_ParametrUpdate(Id, DaramadGroupId, EnName, FnName, Status, UserId, Desc, NoeField, ComboBoxId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroup_ParametrDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}