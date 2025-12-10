using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_NumberingFormat
    {
        #region Detail
        public OBJ_NumberingFormat Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblNumberingFormatSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_NumberingFormat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldSecretariatID = q.fldSecretariatID,
                        fldNumberFormat = q.fldNumberFormat,
                        fldStartNumber = q.fldStartNumber,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_NumberingFormat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblNumberingFormatSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_NumberingFormat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldSecretariatID = q.fldSecretariatID,
                        fldNumberFormat = q.fldNumberFormat,
                        fldStartNumber = q.fldStartNumber,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int Year, int SecretariatID, string NumberFormat, int StartNumber, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblNumberingFormatInsert(Year, SecretariatID, NumberFormat, StartNumber, OrganID, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int Year, int SecretariatID, string NumberFormat, int StartNumber, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblNumberingFormatUpdate(Id, Year, SecretariatID, NumberFormat, StartNumber, OrganID, UserId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblNumberingFormatDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int Year, int SecretariatID, int Id)
        {
            bool q = false;
            using (AutomationEntities p = new AutomationEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblNumberingFormatSelect("fldYear_SecretariatID", Year.ToString(), SecretariatID, 0).Any();

                }
                else
                {
                    var query = p.spr_tblNumberingFormatSelect("fldYear_SecretariatID", Year.ToString(), SecretariatID, 0).FirstOrDefault();
                    if (query != null && query.fldID != Id)
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