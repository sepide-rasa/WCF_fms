using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_Letter
    {
        #region Detail
        public OBJ_Letter Detail(long Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Letter()
                    {
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear,
                        fldOrderId = q.fldOrderId,
                        fldSubject = q.fldSubject,
                        fldLetterNumber = q.fldLetterNumber,
                        fldLetterDate = q.fldLetterDate,
                        fldCreatedDate = q.fldCreatedDate,
                        fldKeywords = q.fldKeywords,
                        fldLetterStatusID = q.fldLetterStatusID,
                        fldComisionID = q.fldComisionID,
                        fldImmediacyID = q.fldImmediacyID,
                        fldSecurityTypeID = q.fldSecurityTypeID,
                        fldLetterTypeID = q.fldLetterTypeID,
                        fldSignType = q.fldSignType,
                        fldCreatedDateEn = q.fldCreatedDateEn,
                        fldLetterStatusName = q.fldLetterStatusName,
                        fldImmediacyName = q.fldImmediacyName,
                        fldLetterTypeName = q.fldLetterTypeName,
                        fldSecurityTypeName = q.fldSecurityTypeName,
                        fldSenderName = q.fldSenderName,
                        fldRecieverName = q.fldRecieverName,
                        fldReceiver = q.fldReceiver,
                        fldRoonevesht = q.fldRoonevesht,
                        fldSigner = q.fldSigner,
                        fldSignerName = q.fldSignerName,
                        fldExternalSender = q.fldExternalSender,
                        fldExternalSenderName = q.fldExternalSenderName,
                        fldMatnLetter = q.fldMatnLetter,
                        fldLetterTemplateId = q.fldLetterTemplateId,
                        fldContentFileID = q.fldContentFileID,
                        fldFont = q.fldFont
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Letter> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Letter()
                    {
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear,
                        fldOrderId = q.fldOrderId,
                        fldSubject = q.fldSubject,
                        fldLetterNumber = q.fldLetterNumber,
                        fldLetterDate = q.fldLetterDate,
                        fldCreatedDate = q.fldCreatedDate,
                        fldKeywords = q.fldKeywords,
                        fldLetterStatusID = q.fldLetterStatusID,
                        fldComisionID = q.fldComisionID,
                        fldImmediacyID = q.fldImmediacyID,
                        fldSecurityTypeID = q.fldSecurityTypeID,
                        fldLetterTypeID = q.fldLetterTypeID,
                        fldSignType = q.fldSignType,
                        fldCreatedDateEn = q.fldCreatedDateEn,
                        fldLetterStatusName = q.fldLetterStatusName,
                        fldImmediacyName = q.fldImmediacyName,
                        fldLetterTypeName = q.fldLetterTypeName,
                        fldSecurityTypeName = q.fldSecurityTypeName,
                        fldSenderName = q.fldSenderName,
                        fldRecieverName = q.fldRecieverName,
                        fldReceiver=q.fldReceiver,
                        fldRoonevesht=q.fldRoonevesht,
                        fldSigner = q.fldSigner,
                        fldSignerName = q.fldSignerName,
                        fldExternalSender = q.fldExternalSender,
                        fldExternalSenderName = q.fldExternalSenderName,
                        fldMatnLetter = q.fldMatnLetter,
                        fldLetterTemplateId = q.fldLetterTemplateId,
                        fldContentFileID = q.fldContentFileID,
                        fldFont=q.fldFont
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public ClsError Insert(int fldYear,string fldSubject,string fldLetterNumber,string fldLetterDate,string fldKeywords,int fldLetterStatusID
            , int fldComisionID, int fldImmediacyID, int fldSecurityTypeID, int fldLetterTypeID, byte fldSignType, string MatnLetter, int? LetterTempId,string fldFont, int OrganID, int UserId, string Desc, string IP)
        {
            ClsError Message = new ClsError();
            using (AutomationEntities p = new AutomationEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                System.Data.Entity.Core.Objects.ObjectParameter OrderId = new System.Data.Entity.Core.Objects.ObjectParameter("fldOrderId", typeof(int));
                p.spr_tblLetterInsert(Id, fldYear, OrderId, fldSubject, fldLetterNumber, fldLetterDate, fldKeywords, fldLetterStatusID, fldComisionID,
                   fldImmediacyID, fldSecurityTypeID, fldLetterTypeID, fldSignType,MatnLetter,LetterTempId,fldFont, UserId, Desc, OrganID, IP);
                Message.OutputId = Convert.ToInt32(Id.Value);
                Message.OutputId2 = Convert.ToInt32(OrderId.Value);
                Message.Msg = "ویرایش با موفقیت انجام شد.";
                Message.ErrorMsg = "ویرایش موفق";
            }
            return Message;
        }
        #endregion
        #region Update
         public string Update(long Id,string fldSubject, string fldLetterNumber, string fldLetterDate, string fldKeywords
            , int fldComisionID, int fldImmediacyID, int fldSecurityTypeID, int fldLetterTypeID, byte fldSignType, string MatnLetter, int? LetterTempId,string fldFont, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterUpdate(Id, fldSubject, fldLetterNumber, fldLetterDate, fldKeywords,fldComisionID,
                   fldImmediacyID, fldSecurityTypeID, fldLetterTypeID, fldSignType,MatnLetter,LetterTempId,fldFont, UserId, Desc, OrganID, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string  Delete(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateLetterNumDate
         public string UpdateLetterNumDate(long Id, string fldLetterNumber, int OrganID, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterUpdateNumDate(Id, fldLetterNumber, UserId, OrganID);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateLetterStatusId
         public string UpdateLetterStatusId(long LetterId, int fldLetterStatusID, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterStatusIdUpdate(LetterId, fldLetterStatusID,UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

         #region SelectInbox
         public List<OBJ_Inbox> SelectInbox(string FieldName, string Start, string End, int BoxId,int TabaghebandiId,int OrganId,string Value,int h)
         {
             using (AutomationEntities p = new AutomationEntities())
             {
                 var k = p.spr_SelectInbox(FieldName,h, Start, End, BoxId, OrganId, Value,TabaghebandiId)
                     .Select(q => new OBJ_Inbox()
                     {
                         fldLetterId = q.fldLetterId,
                         fldMessageId = q.fldMessageId,
                         fldOrderId = q.fldOrderId,
                         fldCommision = q.fldCommision,
                         fldComisionID = q.fldComisionID,
                         fldSubject = q.fldSubject,
                         fldLetterstatus = q.fldLetterstatus,
                         fldLetterType = q.fldLetterType,
                         fldLetterTypeID = q.fldLetterTypeID,
                         HaveAttach = q.HaveAttach,
                         LetterRecievers = q.LetterRecievers,
                         fldAssignmentDate = q.fldAssignmentDate,
                         assigmentid = q.assigmentid,
                         fldAnswerDate = q.fldAnswerDate,
                         fldReceiverComisionID = q.fldReceiverComisionID,
                         fldAssignmentStatusID = q.fldAssignmentStatusID,
                         fldImmediacyID = q.fldImmediacyID,
                         fldLetterDate = q.fldLetterDate,
                         fldLetterNumber = q.fldLetterNumber,
                         HaveArchiv = q.HaveArchiv,
                         AssimentLetterStatus = q.AssimentLetterStatus,
                         AssimentLetterStatusId = q.AssimentLetterStatusId,
                         fldImmediacyName = q.fldImmediacyName,
                         InternalAssignmentReceiverID = q.InternalAssignmentReceiverID,
                         fldCreatedDate = q.fldCreatedDate,
                         fldSecurityType = q.fldSecurityType,
                         fldDesc = q.fldDesc,
                         fldKeywords = q.fldKeywords,
                         fldSenderComisionID = q.fldSenderComisionID
                     }).ToList();
                 return k;
             }
         }
        #endregion
         #region SelectSavedLetter
         public List<OBJ_SavedLetter> SelectSavedLetter(string FieldName, string Start, string End, string BoxId,int TabaghebandiId, string value, int OrganId,int h)
         {
             using (AutomationEntities p = new AutomationEntities())
             {
                 var k = p.spr_SelectSavedLetter(FieldName, h, Start, End, BoxId, value, OrganId, TabaghebandiId)
                     .Select(q => new OBJ_SavedLetter()
                     {
                         fldLetterId = q.fldLetterId,
                         fldMessageId = q.fldMessageId,
                         fldOrderId = q.fldOrderId,
                         fldSubject = q.fldSubject,
                         fldLetterNumber = q.fldLetterNumber,
                         fldLetterDate = q.fldLetterDate,
                         fldCreatedDate = q.fldCreatedDate,
                         fldLetterStatus = q.fldLetterStatus,
                         fldImmediacyName = q.fldImmediacyName,
                         fldLetterType = q.fldLetterType,
                         fldLetterTypeID = q.fldLetterTypeID,
                         fldImmediacyID = q.fldImmediacyID,
                         HaveArchiv = q.HaveArchiv,
                         HaveAttach=q.HaveAttach,
                         fldSecurityType = q.fldSecurityType,
                         fldCommision = q.fldCommision,
                         LetterRecievers = q.LetterRecievers,
                         fldKeywords = q.fldKeywords,
                         fldDesc = q.fldDesc
                     }).ToList();
                 return k;
             }
         }
         #endregion

         #region SelectSent
         public List<OBJ_Sent> SelectSent(string FieldName, string Start, string End, int BoxId,int TabaghebandiId, string Value, int OrganId,int h)
         {
             using (AutomationEntities p = new AutomationEntities())
             {
                 var k = p.spr_SelectSent(FieldName, h, Start, End, BoxId, OrganId, Value, TabaghebandiId)
                     .Select(q => new OBJ_Sent()
                     {
                         code = q.code,
                         fldLetterId = q.fldLetterId,
                         fldMessageId = q.fldMessageId,
                         fldOrderId = q.fldOrderId,
                         fldCommision = q.fldCommision,
                         fldComisionID = q.fldComisionID,
                         fldSubject = q.fldSubject,
                         fldLetterstatus = q.fldLetterstatus,
                         fldLetterType = q.fldLetterType,
                         fldLetterTypeID = q.fldLetterTypeID,
                         HaveAttach = q.HaveAttach,
                         LetterRecievers = q.LetterRecievers,
                         fldAssignmentDate = q.fldAssignmentDate,
                         assigmentid = q.assigmentid,
                         fldAnswerDate = q.fldAnswerDate,
                         fldSenderComisionID = q.fldSenderComisionID,
                         fldImmediacyID = q.fldImmediacyID,
                         fldLetterDate = q.fldLetterDate,
                         fldLetterNumber = q.fldLetterNumber,
                         HaveArchiv = q.HaveArchiv,
                         fldImmediacyName = q.fldImmediacyName,
                         fldAssignmentTypeID = q.fldAssignmentTypeID,
                         InternalAssignmentReceiverID = q.InternalAssignmentReceiverID,
                         fldLetterStatusID = q.fldLetterStatusID,
                         fldAssignmentStatusID = q.fldAssignmentStatusID,
                         fldCreatedDate = q.fldCreatedDate,
                         fldSecurityType = q.fldSecurityType,
                         fldDesc = q.fldDesc,
                         fldKeywords = q.fldKeywords
                     }).ToList();
                 return k;
             }
         }
         #endregion

         #region SelectTrash
         public List<OBJ_Trash> SelectTrash(string FieldName, string Start, string End, int BoxId,int TabaghebandiId,string Value, int OrganId,int h)
         {
             using (AutomationEntities p = new AutomationEntities())
             {
                 var k = p.spr_SelectTrash(FieldName, h, Start, End, BoxId, OrganId, Value, TabaghebandiId)
                     .Select(q => new OBJ_Trash()
                     {
                         code = q.code,
                         fldLetterId = q.fldLetterId,
                         fldOrderId = q.fldOrderId,
                         fldComisionID = q.fldComisionID,
                         fldSubject = q.fldSubject,
                         fldLetterstatus = q.fldLetterstatus,
                         fldLetterType = q.fldLetterType,
                         fldLetterTypeID = q.fldLetterTypeID,
                         fldAssigmentDate = q.fldAssigmentDate,
                         assigmentid = q.assigmentid,
                         fldAnswerDate = q.fldAnswerDate,
                         fldSenderComisionID = q.fldSenderComisionID,
                         fldImmediacyID = q.fldImmediacyID,
                         fldLetterDate = q.fldLetterDate,
                         fldLetterNumber = q.fldLetterNumber,
                         fldImmediacyName = q.fldImmediacyName,
                         fldTrashType = q.fldTrashType,
                         fldDelDate = q.fldDelDate,
                         fldMessageId = q.fldMessageId,
                         fldCommision = q.fldCommision,
                         HaveAttach = q.HaveAttach,
                         LetterRecievers = q.LetterRecievers,
                         HaveArchiv = q.HaveArchiv,
                         fldCreatedDate = q.fldCreatedDate,
                         fldSecurityType = q.fldSecurityType,
                         fldDesc = q.fldDesc,
                         fldKeywords = q.fldKeywords
                     }).ToList();
                 return k;
             }
         }
         #endregion
    }
}