using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_AssignmentType
    {
        #region Detail
        public OBJ_AssignmentType Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblAssignmentTypeSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_AssignmentType()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldType = q.fldType
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AssignmentType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblAssignmentTypeSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_AssignmentType()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldType = q.fldType
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldType, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblAssignmentTypeInsert(fldType, OrganID, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldType, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblAssignmentTypeUpdate(Id, fldType, OrganID, UserId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblAssignmentTypeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}