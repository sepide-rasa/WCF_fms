using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_Box
    {
        #region Detail
        public OBJ_Box Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblBoxSelect("fldId", Id.ToString(), OrganId,"", 1)
                    .Select(q => new OBJ_Box()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldName = q.fldName,
                        fldComisionID = q.fldComisionID,
                        fldBoxTypeID = q.fldBoxTypeID,
                        fldPID = q.fldPID,
                        chidId = q.chidId,
                        childName = q.childName,
                        tedad = q.tedad
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Box> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblBoxSelect(FieldName, FilterValue, OrganId,FilterValue2, h)
                    .Select(q => new OBJ_Box()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldName = q.fldName,
                        fldComisionID = q.fldComisionID,
                        fldBoxTypeID = q.fldBoxTypeID,
                        fldPID = q.fldPID,
                        chidId = q.chidId,
                        childName = q.childName,
                        tedad = q.tedad
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldComisionID, int fldBoxTypeID, int? fldPID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblBoxInsert(fldName, fldComisionID, fldBoxTypeID, fldPID, OrganID, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldComisionID, int fldBoxTypeID, int? fldPID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblBoxUpdate(Id, fldName, fldComisionID, fldBoxTypeID, fldPID, OrganID, UserId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblBoxDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region GetBoxTypeId
        public List<OBJ_BoxType> GetBoxTypeId(int NodeId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_GetBoxTypeId(NodeId)
                    .Select(q => new OBJ_BoxType()
                    {
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldBoxType = q.fldBoxType,
                        fldPID = q.fldPID
                    }).ToList();
                return k;
            }
        }
        #endregion

        #region SelectBoxType
        public List<OBJ_BoxType> SelectBoxType(string FieldName, string FilterValue,  int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblBoxTypeSelect(FieldName, FilterValue,h)
                    .Select(q => new OBJ_BoxType()
                    {
                        fldId = q.fldID,
                        fldName = q.fldType
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}