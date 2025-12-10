using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_TabagheBandi
    {
        #region Detail
        public OBJ_TabagheBandi Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblTabagheBandiSelect("fldId", Id.ToString(),"", OrganId, 1)
                    .Select(q => new OBJ_TabagheBandi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldName = q.fldName,
                        fldComisionID = q.fldComisionID,
                        fldPID = q.fldPID,
                        chidId = q.chidId,
                        childName = q.childName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TabagheBandi> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblTabagheBandiSelect(FieldName, FilterValue,FilterValue2, OrganId, h)
                    .Select(q => new OBJ_TabagheBandi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldName = q.fldName,
                        fldComisionID = q.fldComisionID,
                        fldPID = q.fldPID,
                        chidId = q.chidId,
                        childName=q.childName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldComisionID, int? fldPID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblTabagheBandiInsert(fldName, fldComisionID, fldPID, OrganID, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldComisionID, int? fldPID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblTabagheBandiUpdate(Id, fldName, fldComisionID, fldPID, OrganID, UserId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblTabagheBandiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}