using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_Setting
    {
        #region Detail
        public OBJ_Setting Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblProgramSettingSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Setting()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldDelFax = q.fldDelFax,
                        fldEmailAddress = q.fldEmailAddress,
                        fldEmailPassword = q.fldEmailPassword,
                        fldFaxPath = q.fldFaxPath,
                        fldIsSigner = q.fldIsSigner,
                        fldRecieveServer = q.fldRecieveServer,
                        fldSendPort = q.fldSendPort,
                        fldSendServer = q.fldSendServer,
                        fldSSL = q.fldSSL,
                        fldRecievePort = q.fldRecievePort,
                        NameOrgan = q.NameOrgan

                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Setting> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblProgramSettingSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Setting()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganID = q.fldOrganID,
                        fldDelFax = q.fldDelFax,
                        fldEmailAddress = q.fldEmailAddress,
                        fldEmailPassword = q.fldEmailPassword,
                        fldFaxPath = q.fldFaxPath,
                        fldIsSigner = q.fldIsSigner,
                        fldRecieveServer = q.fldRecieveServer,
                        fldSendPort = q.fldSendPort,
                        fldSendServer = q.fldSendServer,
                        fldSSL = q.fldSSL,
                        fldRecievePort=q.fldRecievePort,
                        NameOrgan=q.NameOrgan
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string EmailAddress, string EmailPassword, string RecieveServer, string SendServer, int SendPort, bool SSL, bool DelFax, bool IsSigner, string FaxPath,int RecievePort, int OrganID, int UserID, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblProgramSettingInsert(EmailAddress, EmailPassword, RecieveServer, SendServer, SendPort, SSL, DelFax, IsSigner, FaxPath, OrganID, UserID, Desc, IP, RecievePort);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string EmailAddress, string EmailPassword, string RecieveServer, string SendServer, int SendPort, bool SSL, bool DelFax, bool IsSigner, string FaxPath, int RecievePort, int OrganID, int UserID, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblProgramSettingUpdate(Id, EmailAddress, EmailPassword, RecieveServer, SendServer, SendPort, SSL, DelFax, IsSigner, FaxPath, OrganID, UserID, Desc, IP, RecievePort);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblProgramSettingDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}