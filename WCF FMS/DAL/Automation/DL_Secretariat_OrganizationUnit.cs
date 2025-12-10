using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;
namespace WCF_FMS.DAL.Automation
{
    public class DL_Secretariat_OrganizationUnit
    {
        #region Detail
        public OBJ_Secretariat_OrganizationUnit Detail(int id,int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblSecretariat_OrganizationUnitSelect("fldId", id.ToString(),OrganId, 1)
                .Select(q => new OBJ_Secretariat_OrganizationUnit
                {
                    fldID = q.fldID,
                    fldSecretariatID = q.fldSecretariatID,
                    fldOrganizationUnitID = q.fldOrganizationUnitID,
                    fldDate = q.fldDate,
                    fldUserID = q.fldUserID,
                    fldDesc = q.fldDesc,
                    fldIP = q.fldIP,
                    fldOrganId = q.fldOrganId,
                    fldTitle = q.fldTitle
                }).FirstOrDefault();
                return k;
            }
        }
        #endregion;
        #region Select
        public List<OBJ_Secretariat_OrganizationUnit> Select(string fieldname, string Value, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var test = p.spr_tblSecretariat_OrganizationUnitSelect(fieldname, Value,OrganId, h)
                .Select(q => new OBJ_Secretariat_OrganizationUnit()
               {
                   fldID = q.fldID,
                   fldSecretariatID = q.fldSecretariatID,
                   fldOrganizationUnitID = q.fldOrganizationUnitID,
                   fldDate = q.fldDate,
                   fldUserID = q.fldUserID,
                   fldDesc = q.fldDesc,
                   fldIP = q.fldIP,
                   fldOrganId = q.fldOrganId,
                   fldTitle = q.fldTitle
               }).ToList();
                return test;
            }
        }
        #endregion;
        #region Insert
        public string Insert(int fldSecretariatID, int fldOrganizationUnitID, int fldUserID, string fldDesc, string fldIP, int fldOrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblSecretariat_OrganizationUnitInsert(fldSecretariatID, fldOrganizationUnitID, fldUserID, fldDesc, fldIP, fldOrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion;
        #region Update
        public string Update(int fldID, int fldSecretariatID, int fldOrganizationUnitID, int fldUserID, string fldDesc, string fldIP, int fldOrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblSecretariat_OrganizationUnitUpdate(fldID, fldSecretariatID, fldOrganizationUnitID, fldUserID, fldDesc, fldIP, fldOrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion;
        #region Delete
        public string Delete(string FieldName,int fldID, int fldUserID)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblSecretariat_OrganizationUnitDelete(fldID, fldUserID, FieldName);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion;

        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (AutomationEntities p = new AutomationEntities())
            {
                var N=p.spr_tblNumberingFormatSelect("check_fldSecretariatID", Id.ToString(), 0, 0).FirstOrDefault();
                if (N != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}