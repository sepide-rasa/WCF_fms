using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_TypeEstekhdam_UserGroup
    {
        #region Detail
        public OBJ_TypeEstekhdam_UserGroup Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTypeEstekhdam_UserGroupSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_TypeEstekhdam_UserGroup()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTypeEstekhamId = q.fldTypeEstekhamId,
                        fldUserId = q.fldUserId,
                        fldUseGroupId = q.fldUseGroupId,
                        fldOrganId = q.fldOrganId,
                        fldTitleUserGroup = q.fldTitleUserGroup,
                        fldTypeEstekhdamTitle = q.fldTypeEstekhdamTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TypeEstekhdam_UserGroup> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTypeEstekhdam_UserGroupSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_TypeEstekhdam_UserGroup()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTypeEstekhamId = q.fldTypeEstekhamId,
                        fldUserId = q.fldUserId,
                        fldUseGroupId = q.fldUseGroupId,
                        fldOrganId = q.fldOrganId,
                        fldTitleUserGroup = q.fldTitleUserGroup,
                        fldTypeEstekhdamTitle = q.fldTypeEstekhdamTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTypeEstekhamId, int fldUseGroupId, int OrganId, int UserId, string Desc,string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblTypeEstekhdam_UserGroupInsert(fldTypeEstekhamId, fldUseGroupId, OrganId, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldTypeEstekhamId, int fldUseGroupId, int OrganId, int UserId, string Desc, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblTypeEstekhdam_UserGroupUpdate(Id, fldTypeEstekhamId, fldUseGroupId, OrganId,  UserId, Desc,IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int UserGroupId, int UserId, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblTypeEstekhdam_UserGroupDelete(UserGroupId, UserId, OrganId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}