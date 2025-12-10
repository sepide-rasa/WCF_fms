using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterTabagheBandi
    {
        #region Detail
        public OBJ_LetterTabagheBandi Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterTabagheBandiSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_LetterTabagheBandi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldTabagheBandiId = q.fldTabagheBandiId,
                        fldLetterId = q.fldLetterId,
                        fldNameTabagheBandi = q.fldNameTabagheBandi,
                        fldMessageId = q.fldMessageId,
                        fldTitleMessage = q.fldTitleMessage
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterTabagheBandi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterTabagheBandiSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterTabagheBandi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldTabagheBandiId = q.fldTabagheBandiId,
                        fldLetterId = q.fldLetterId,
                        fldNameTabagheBandi = q.fldNameTabagheBandi,
                        fldMessageId = q.fldMessageId,
                        fldTitleMessage = q.fldTitleMessage
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldTabagheBandiId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterTabagheBandiInsert(fldTabagheBandiId, fldLetterId, fldMessageId, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldTabagheBandiId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterTabagheBandiUpdate(Id, fldTabagheBandiId,fldMessageId, fldLetterId, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterTabagheBandiDelete(FieldName,Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}