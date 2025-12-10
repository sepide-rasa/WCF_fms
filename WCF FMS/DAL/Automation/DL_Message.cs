using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_Message
    {
        #region Detail
        public OBJ_Message Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblMessageSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Message()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldCommisionId = q.fldCommisionId,
                        fldTitle = q.fldTitle,
                        fldMatn = q.fldMatn,
                        fldTarikhShamsi = q.fldTarikhShamsi
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Message> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblMessageSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Message()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldCommisionId = q.fldCommisionId,
                        fldTitle = q.fldTitle,
                        fldMatn = q.fldMatn,
                        fldTarikhShamsi = q.fldTarikhShamsi
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int fldCommisionId, string fldTitle, string fldMatn, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblMessageInsert(Id,fldCommisionId,fldTitle,fldMatn, UserId, Desc, OrganID, IP);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldCommisionId, string fldTitle, string fldMatn, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMessageUpdate(Id, fldCommisionId, fldTitle, fldMatn, UserId, Desc, OrganID, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMessageDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region SelectSavedMessage
        public List<OBJ_SavedMessage> SelectSavedMessage(string FieldName, string Start, string End, string BoxId, int TabaghebandiId, string Value, int OrganId,int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_SelectSavedMessage(FieldName, h, Start, End, BoxId,Value, OrganId, TabaghebandiId)
                    .Select(q => new OBJ_SavedMessage()
                    {
                        fldTitleMessge = q.fldTitleMessge,
                        fldMatn = q.fldMatn,
                        fldtarikh = q.fldtarikh,
                        fldMessageId=q.fldMessageId,
                        fldLetterId=q.fldLetterId,
                        HaveAttach = q.HaveAttach,
                        fldCommision = q.fldCommision,
                        LetterRecievers = q.LetterRecievers,
                        fldDesc = q.fldDesc
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}