using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAutomationService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IAutomationService
    {
        //Commision
        #region Commision
        [OperationContract]
        OBJ_Commision GetCommisionDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Commision> GetCommisionWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCommision(int AshkhasID, int OrganizPostEjraeeID, string StartDate, string EndDate, string OraganicNumber, bool fldSign, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCommision(int Id, int AshkhasID, int OrganizPostEjraeeID, string StartDate, string EndDate, string OraganicNumber, bool fldSign, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCommision(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Commision> GetCommision_Post(int fldId, int OrganId, string IP, out ClsError Error);
        #endregion

        //AssignmentType
        #region AssignmentType
        [OperationContract]
        OBJ_AssignmentType GetAssignmentTypeDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AssignmentType> GetAssignmentTypeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAssignmentType(string fldType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAssignmentType(int Id, string fldType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAssignmentType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Immediacy
        #region Immediacy
        [OperationContract]
        OBJ_Immediacy GetImmediacyDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Immediacy> GetImmediacyWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertImmediacy(string Name, byte[] Image, string Passvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateImmediacy(int Id, string Name, int? FileId, byte[] Image, string Passvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteImmediacy(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //NumberingFormat
        #region NumberingFormat
        [OperationContract]
        OBJ_NumberingFormat GetNumberingFormatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_NumberingFormat> GetNumberingFormatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertNumberingFormat(int Year, int SecretariatID, string NumberFormat, int StartNumber, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateNumberingFormat(int Id, int Year, int SecretariatID, string NumberFormat, int StartNumber, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteNumberingFormat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SecurityType
        #region SecurityType
        [OperationContract]
        OBJ_SecurityType GetSecurityTypeDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SecurityType> GetSecurityTypeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSecurityType(string SecurityType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSecurityType(int Id, string SecurityType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSecurityType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion


        //Setting
        #region Setting
        [OperationContract]
        OBJ_Setting GetSettingDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Setting> GetSettingWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSetting(string EmailAddress, string EmailPassword, string RecieveServer, string SendServer, int SendPort, bool SSL, bool DelFax, bool IsSigner, string FaxPath, int RecievePort, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSetting(int Id, string EmailAddress, string EmailPassword, string RecieveServer, string SendServer, int SendPort, bool SSL, bool DelFax, bool IsSigner, string FaxPath, int RecievePort, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSetting(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Secretariat_OrganizationUnit
        #region Secretariat_OrganizationUnit
        [OperationContract]
        OBJ_Secretariat_OrganizationUnit GetSecretariat_OrganizationUnitDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Secretariat_OrganizationUnit> GetSecretariat_OrganizationUnitWithFilter(string fieldname, string Value, int OrganId, int h, string IP, out ClsError Error);
        [OperationContract]
        string InsertSecretariat_OrganizationUnit(int fldSecretariatID, int fldOrganizationUnitID, string fldDesc, int fldOrganId, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSecretariat_OrganizationUnit(int fldID, int fldSecretariatID, int fldOrganizationUnitID, string fldDesc, int OrganId, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSecretariat_OrganizationUnit(string FieldName, int fldID, int OrganId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //Substitute
        #region Substitute
        [OperationContract]
        OBJ_Substitute GetSubstituteDetail(int Id, int OrganId, string fldIP, out ClsError Error);
        [OperationContract]
        List<OBJ_Substitute> GetSubstituteWithFilter(string fieldname, string Value, int fldOrganId, int h, string fldIP, out ClsError Error);
        [OperationContract]
        string InsertSubstitute(int fldSenderComisionID, int fldReceiverComisionID, string fldStartDate, string fldEndDate, string fldStartTime, string fldEndTime, bool fldIsSigner, bool fldShowReceiverName, string fldDesc, string fldIP, int fldOrganId, string Username, string Password, out ClsError Error);
        [OperationContract]
        string UpdateSubstitute(int fldID, int fldSenderComisionID, int fldReceiverComisionID, string fldStartDate, string fldEndDate, string fldStartTime, string fldEndTime, bool fldIsSigner, bool fldShowReceiverName, string fldDesc, string fldIP, int fldOrganId, string Username, string Password, out ClsError Error);
        [OperationContract]
        string DeleteSubstitute(int fldID, string Username, string Password, int OrganId, string fldIP, out ClsError Error);
        #endregion

        //MergeFieldTypes
        #region MergeFieldTypes
        [OperationContract]
        List<OBJ_MergeFieldTypes> GetMergeFieldTypesWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //LetterTemplate
        #region LetterTemplate
        [OperationContract]
        OBJ_LetterTemplate GetLetterTemplateDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LetterTemplate> GetLetterTemplateWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLetterTemplate(string fldName, bool fldIsBackGround, byte[] fldImage, string fldPasvand, string fldMergeFieldId, byte[] LetterFile, string LetterPasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterTemplate(int Id, string fldName, bool fldIsBackGround, int? fldFileId, byte[] fldImage, string fldPasvand, string fldMergeFieldId, byte[] LetterFile, string LetterPasvand, int? LetterFileId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterTemplate(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterTemplate_Format(int Id, string fldFormat, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MergeField_LetterTemplate
        #region MergeField_LetterTemplate
        [OperationContract]
        OBJ_MergeField_LetterTemplate GetMergeField_LetterTemplateDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MergeField_LetterTemplate> GetMergeField_LetterTemplateWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMergeField_LetterTemplate(int fldLetterTamplateId, int fldMergeFieldId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMergeField_LetterTemplate(int Id, int fldLetterTamplateId, int fldMergeFieldId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMergeField_LetterTemplate(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ReferralRules
        #region ReferralRules
        [OperationContract]
        OBJ_ReferralRules GetReferralRulesDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ReferralRules> GetReferralRulesWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertReferralRules(int fldPostErjaDahandeId, int? fldPostErjaGirandeId, int? fldChartEjraeeGirandeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateReferralRules(int Id, int fldPostErjaDahandeId, int? fldPostErjaGirandeId, int? fldChartEjraeeGirandeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteReferralRules(int fldPostErjaDahandeId, int OrganErjaGirande, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Message
        #region Message
        [OperationContract]
        OBJ_Message GetMessageDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Message> GetMessageWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertMessage(int fldCommisionId, string fldTitle, string fldMatn, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMessage(int Id, int fldCommisionId, string fldTitle, string fldMatn, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMessage(int Id, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SavedMessage> GetSavedMessageWithFilter(string FieldName, string Start, string End, string BoxId,int TabaghebandiId, string Value, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //MessageAttachment
        #region MessageAttachment
        [OperationContract]
        OBJ_MessageAttachment GetMessageAttachmentDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MessageAttachment> GetMessageAttachmentWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMessageAttachment(string fldTitle,int fldMessageId, byte[] fldImage, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMessageAttachment(int Id, string fldTitle, int fldMessageId, int fldFileId, byte[] fldImage, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMessageAttachment(int Id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //LetterFileMojaz
        #region LetterFileMojaz
        [OperationContract]
        OBJ_LetterFileMojaz GetLetterFileMojazDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LetterFileMojaz> GetLetterFileMojazWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLetterFileMojaz(byte fldFormatFileId, byte fldType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterFileMojaz(int Id, byte fldFormatFileId, byte fldType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterFileMojaz(int Id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Box
        #region Box
        [OperationContract]
        OBJ_Box GetBoxDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Box> GetBoxWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertBox(string fldName, int fldComisionID, int fldBoxTypeID, int? fldPID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateBox(int Id, string fldName, int fldComisionID, int fldBoxTypeID, int? fldPID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteBox(int Id, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_BoxType> GetBoxTypeId(int NodeId, string IP, out ClsError Error);
         [OperationContract]
         List<OBJ_BoxType> GetBoxTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);


        #endregion

        //TabagheBandi
        #region TabagheBandi
        [OperationContract]
        OBJ_TabagheBandi GetTabagheBandiDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TabagheBandi> GetTabagheBandiWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTabagheBandi(string fldName, int fldComisionID, int? fldPID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTabagheBandi(int Id, string fldName, int fldComisionID, int? fldPID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTabagheBandi(int Id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //LetterStatus
        #region LetterStatus
        [OperationContract]
        List<OBJ_LetterStatus> GetLetterStatusWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Letter
        #region Letter
        [OperationContract]
         OBJ_Letter GetLetterDetail(long Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Letter> GetLetterWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        ClsError InsertLetter(int fldYear, string fldSubject, string fldLetterNumber, string fldLetterDate, string fldKeywords, int fldLetterStatusID
            , int fldComisionID, int fldImmediacyID, int fldSecurityTypeID, int fldLetterTypeID, byte fldSignType, string MatnLetter, int? LetterTempId,string fldFont, string Desc, string Username, string Password, int OrganId, string IP);
        [OperationContract]
        string UpdateLetter(long Id,  string fldSubject, string fldLetterNumber, string fldLetterDate, string fldKeywords
            , int fldComisionID, int fldImmediacyID, int fldSecurityTypeID, int fldLetterTypeID, byte fldSignType, string MatnLetter, int? LetterTempId,string fldFont, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetter(long Id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterNumDate(long Id, string fldLetterNumber, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterStatusId(long LetterId, int fldLetterStatusID, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Inbox> SelectInbox(string FieldName, string Start, string End, int BoxId,int TabaghebandiId, string Value, int OrganId, int Top, string IP, out ClsError Error);
         [OperationContract]
        List<OBJ_SavedLetter> SelectSavedLetter(string FieldName, string Start, string End, string BoxId, int TabaghebandiId, string value, int OrganId, int Top, string IP, out ClsError Error);
         [OperationContract]
         List<OBJ_Sent> SelectSent(string FieldName, string Start, string End, int BoxId, int TabaghebandiId, string Value, int OrganId, int Top, string IP, out ClsError Error);
         [OperationContract]
         List<OBJ_Trash> SelectTrash(string FieldName, string Start, string End, int BoxId, int TabaghebandiId, string Value, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //LetterBox
        #region LetterBox
        [OperationContract]
         OBJ_LetterBox GetLetterBoxDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LetterBox> GetLetterBoxWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLetterBox(int fldBoxId, long? fldLetterId, int? fldMessageId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterBox(int Id, int fldBoxId, long? fldLetterId, int? fldMessageId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterBox(int Id, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterBoxLetterID(string FieldName, long Id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //LetterTabagheBandi
        #region LetterTabagheBandi
        [OperationContract]
        OBJ_LetterTabagheBandi GetLetterTabagheBandiDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LetterTabagheBandi> GetLetterTabagheBandiWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLetterTabagheBandi(int fldTabagheBandiId, long? fldLetterId, int? fldMessageId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterTabagheBandi(int Id, int fldTabagheBandiId, long? fldLetterId, int? fldMessageId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterTabagheBandi(string FieldName, long Id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //AssignmentStatus
        #region AssignmentStatus
        [OperationContract]
        List<OBJ_AssignmentStatus> GetAssignmentStatusWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Assignment
        #region Assignment
        [OperationContract]
        OBJ_Assignment GetAssignmentDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Assignment> GetAssignmentWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertAssignment(long? fldLetterID, int? fldMessageId, string fldAnswerDate, int? fldSourceAssId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAssignment(int Id, long? fldLetterID, int? fldMessageId, string fldAnswerDate, int? fldSourceAssId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAssignment(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAssignmentLetterID(long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InternalAssignmentReceiver
        #region InternalAssignmentReceiver
        [OperationContract]
        OBJ_InternalAssignmentReceiver GetInternalAssignmentReceiverDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_InternalAssignmentReceiver> GetInternalAssignmentReceiverWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertInternalAssignmentReceiver(int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInternalAssignmentReceiver(int Id, int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteInternalAssignmentReceiver(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInternalAssignmentReceiverBox(int Id, int fldBoxID, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInternalAssignmentReceiverStatus(int Id, int fldStatusID, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InternalAssignmentSender
        #region InternalAssignmentSender
        [OperationContract]
        OBJ_InternalAssignmentSender GetInternalAssignmentSenderDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_InternalAssignmentSender> GetInternalAssignmentSenderWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertInternalAssignmentSender(int fldAssignmentID, int fldSenderComisionID, int fldBoxID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInternalAssignmentSender(int Id, int fldAssignmentID, int fldSenderComisionID, int fldBoxID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteInternalAssignmentSender(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInternalAssignmentSenderBox(int Id, int fldBoxID, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Archive
        #region Archive
        [OperationContract]
        OBJ_Archive GetArchiveDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
         List<OBJ_Archive> GetArchiveWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertArchive(string fldName, int? fldPId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateArchive(int Id, string fldName, int? fldPId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteArchive(int Id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //LetterArchive
        #region LetterArchive
        [OperationContract]
        OBJ_LetterArchive GetLetterArchiveDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LetterArchive> GetLetterArchiveWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLetterArchive(long? fldLetterId, int fldMessageId, int fldArchiveId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterArchive(int Id, long? fldLetterId, int fldMessageId, int fldArchiveId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterArchive(int Id, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterArchiveLetterID(long Id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //Signer
        #region Signer
        [OperationContract]
        OBJ_Signer GetSignerDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Signer> GetSignerWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSigner(long fldLetterId, int fldSignerComisionId, int fldIndexerId, int? fldFirstSigner, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSigner(int Id, long fldLetterId, int fldSignerComisionId, int fldIndexerId, int? fldFirstSigner, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSigner(long Id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //ExternalLetterReceiver
        #region ExternalLetterReceiver
        [OperationContract]
        OBJ_ExternalLetterReceiver GetExternalLetterReceiverDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ExternalLetterReceiver> GetExternalLetterReceiverWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertExternalLetterReceiver(long? fldLetterId, int? fldMessageId, int fldAshkhasHoghoghiTitlesId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateExternalLetterReceiver(int Id, long? fldLetterId, int? fldMessageId, int fldAshkhasHoghoghiTitlesId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteExternalLetterReceiver(long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ExternalLetterSender
        #region ExternalLetterSender
        [OperationContract]
        OBJ_ExternalLetterSender GetExternalLetterSenderDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
         List<OBJ_ExternalLetterSender> GetExternalLetterSenderWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertExternalLetterSender(long? fldLetterId, int? fldMessageId, int fldShakhsHoghoghiTitlesId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateExternalLetterSender(int Id, long? fldLetterId, int? fldMessageId, int fldShakhsHoghoghiTitlesId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteExternalLetterSender(long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InternalLetterReceiver 
        #region InternalLetterReceiver
        [OperationContract]
        OBJ_InternalLetterReceiver GetInternalLetterReceiverDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_InternalLetterReceiver> GetInternalLetterReceiverWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertInternalLetterReceiver(long? fldLetterId, int? fldMessageId, int fldReceiverComisionID, int? fldAssignmentStatusID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInternalLetterReceiver(int Id, long? fldLetterId, int? fldMessageId, int fldReceiverComisionID, int? fldAssignmentStatusID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteInternalLetterReceiver(long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ContentFile
        #region ContentFile
        [OperationContract]
        OBJ_ContentFile GetContentFileDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ContentFile> GetContentFileWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertContentFile(string fldName, byte[] fldLetterText, long fldLetterId, string fldType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateContentFile(int Id, string fldName, byte[] fldLetterText, long fldLetterId, string fldType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteContentFile(long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //LetterAttachment
        #region LetterAttachment
        [OperationContract]
        OBJ_LetterAttachment GetLetterAttachmentDetail(int Id, int OrganId, string IP, out ClsError Error);
         [OperationContract]
        List<OBJ_LetterAttachment> GetLetterAttachmentWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
         [OperationContract]
         string InsertLetterAttachment(long fldLetterId, string fldName, string fldNameFile, byte[] file, string fldType, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
         [OperationContract]
        string UpdateLetterAttachment(int Id, long fldLetterId, string fldName, int fldContentFileId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
         [OperationContract]
         string DeleteLetterAttachment(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
         [OperationContract]
         string DeleteLetterAttachmentLetterID(long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

         //Ronevesht
         #region Ronevesht
         [OperationContract]
        OBJ_Ronevesht GetRoneveshtDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Ronevesht> GetRoneveshtWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertRonevesht(long fldLetterId, int? fldAshkhasHoghoghiTitlesId, int? fldCommisionId, int fldAssignmentTypeId, string fldText, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRonevesht(int Id, long fldLetterId, int? fldAshkhasHoghoghiTitlesId, int? fldCommisionId, int fldAssignmentTypeId, string fldText, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteRonevesht(string FieldNAme, long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //LetterFollow
        #region LetterFollow
        [OperationContract]
        OBJ_LetterFollow GetLetterFollowDetail(int Id, int OrganId, string IP, out ClsError Error);
         [OperationContract]
        List<OBJ_LetterFollow> GetLetterFollowWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
         [OperationContract]
        string InsertLetterFollow(long fldLetterId, string fldLetterText, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
         [OperationContract]
        string UpdateLetterFollow(int Id, long fldLetterId, string fldLetterText, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
         [OperationContract]
         string DeleteLetterFollow(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
         [OperationContract]
         string DeleteLetterFollowLetterID(long id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ReceiverAssignmentTyp
        #region ReceiverAssignmentTyp
        [OperationContract]
        OBJ_ReceiverAssignmentType GetReceiverAssignmentTypeDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ReceiverAssignmentType> GetReceiverAssignmentTypeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertReceiverAssignmentType(int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateReceiverAssignmentType(int Id, int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteReceiverAssignmentType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //LetterNumber
        #region LetterNumber
        [OperationContract]
        int InsertLetterNumber(long fldLetterId, int StartNumber, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //HistoryLetter
        #region HistoryLetter
        [OperationContract]
        OBJ_HistoryLetter GetHistoryLetterDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_HistoryLetter> GetHistoryLetterWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertHistoryLetter(long fldCurrentLetter_Id, int fldHistoryType_Id, long fldHistoryLetter_Id, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateHistoryLetter(int Id, long fldCurrentLetter_Id, int fldHistoryType_Id, long fldHistoryLetter_Id, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteHistoryLetter(int Id, string Username, string Password, string IP, out ClsError Error);
        #endregion
    }
}
