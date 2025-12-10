using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterFileMojaz
    {
        #region Detail
        public OBJ_LetterFileMojaz Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterFileMojazSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_LetterFileMojaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldFormatFileId = q.fldFormatFileId,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldSize = q.fldSize,
                        fldPassvand = q.fldPassvand
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterFileMojaz> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterFileMojazSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterFileMojaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldFormatFileId = q.fldFormatFileId,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldSize = q.fldSize,
                        fldPassvand = q.fldPassvand
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(byte fldFormatFileId, byte fldType, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterFileMojazInsert(fldFormatFileId,fldType, UserId, Desc, OrganID, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, byte fldFormatFileId, byte fldType, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterFileMojazUpdate(Id, fldFormatFileId,fldType, UserId, Desc, OrganID, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterFileMojazDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}