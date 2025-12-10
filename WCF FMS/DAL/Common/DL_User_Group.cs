using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;


namespace WCF_FMS.DAL.Common
{
    public class DL_User_Group
    {
        #region Detail
        public OBJ_User_Group Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblUser_GroupSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_User_Group
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserGroupId = q.fldUserGroupId,
                        fldUserSelectId = q.fldUserSelectId,
                        fldUserId = q.fldUserId,
                        fldGrant = q.fldGrant,
                        fldWithGrant = q.fldWithGrant,
                        fldName = q.fldName,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_User_Group> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblUser_GroupSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_User_Group()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserGroupId = q.fldUserGroupId,
                        fldUserSelectId = q.fldUserSelectId,
                        fldUserId=q.fldUserId,
                        fldGrant = q.fldGrant,
                        fldWithGrant = q.fldWithGrant,
                        fldName = q.fldName,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldUserGroupId, int fldUserSelectId, int UserId, bool fldGrant, bool fldWithGrant, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUser_GroupInsert(fldUserGroupId, fldUserSelectId, UserId, fldGrant, fldWithGrant, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int UserGroupId, int UserSelectId, int UserId, bool fldGrant, bool fldWithGrant, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUser_GroupUpdate(Id, UserGroupId, UserSelectId, UserId,fldGrant,fldWithGrant, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUser_GroupDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int UserSelectId, int UserGroupId, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblUser_GroupSelect("fldUserSelectId", UserSelectId.ToString(), 0).Where(l => l.fldUserGroupId == UserGroupId).Any();
                }
                else
                {
                    var query = p.spr_tblUser_GroupSelect("fldUserSelectId", UserSelectId.ToString(), 0).Where(l => l.fldUserGroupId == UserGroupId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}