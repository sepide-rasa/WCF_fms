using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_Commision
    {
        #region Detail
        public OBJ_Commision Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblCommisionSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Commision()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldEndDate = q.fldEndDate,
                        fldIP = q.fldIP,
                        fldOrganicNumber = q.fldOrganicNumber,
                        fldOrganizPostEjraeeID = q.fldOrganizPostEjraeeID,
                        fldOrganID = q.fldOrganID,
                        fldAshkhasID = q.fldAshkhasID,
                        fldStartDate = q.fldStartDate,
                        fldName = q.fldName,
                        fldO_postEjraee_Title = q.fldO_postEjraee_Title,
                        fldCodeMelli = q.fldCodeMelli,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldActive = q.fldActive,
                        fldFatherName = q.fldFatherName,
                        fldSign = q.fldSign,
                        fldSignName = q.fldSignName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Commision> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblCommisionSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Commision()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldEndDate = q.fldEndDate,
                        fldIP = q.fldIP,
                        fldOrganicNumber = q.fldOrganicNumber,
                        fldOrganizPostEjraeeID = q.fldOrganizPostEjraeeID,
                        fldOrganID = q.fldOrganID,
                        fldAshkhasID = q.fldAshkhasID,
                        fldStartDate = q.fldStartDate,
                        fldName = q.fldName,
                        fldO_postEjraee_Title = q.fldO_postEjraee_Title,
                        fldCodeMelli = q.fldCodeMelli,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldActive = q.fldActive,
                        fldFatherName = q.fldFatherName,
                        fldSign = q.fldSign,
                        fldSignName = q.fldSignName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int AshkhasID, int OrganizPostEjraeeID, string StartDate, string EndDate, string OraganicNumber, bool fldSign, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblCommisionInsert(AshkhasID, OrganizPostEjraeeID, StartDate, EndDate, OraganicNumber, fldSign, OrganID, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int AshkhasID, int OrganizPostEjraeeID, string StartDate, string EndDate, string OraganicNumber, bool fldSign, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblCommisionUpdate(Id, AshkhasID, OrganizPostEjraeeID, StartDate, EndDate, OraganicNumber, fldSign, OrganID, UserId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblCommisionDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string AzTarikh,string TaTarikh,int AshkhasID, int OrganizPostEjraeeID, int Id)
        {
            bool q = false;
            using (AutomationEntities p = new AutomationEntities())
            {
                if (Id == 0)
                {
                    //q = p.spr_tblCommisionSelect("fldAshkhas_OrganPost", AshkhasID.ToString(), OrganizPostEjraeeID, 0).Any();
                    q = p.spr_CheckTarikhForPostCommision(AzTarikh, TaTarikh, OrganizPostEjraeeID, AshkhasID).Any();
                }
                else
                {
                    //var query = p.spr_tblCommisionSelect("fldAshkhas_OrganPost", AshkhasID.ToString(), OrganizPostEjraeeID, 0).FirstOrDefault();
                    var query = p.spr_CheckTarikhForPostCommision(AzTarikh, TaTarikh, OrganizPostEjraeeID, AshkhasID).FirstOrDefault();
                    if (query != null && query.fldID != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CommisionSelect_Post
        public List<OBJ_Commision> CommisionSelect_Post(int fldId,int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblCommisionSelect_Post(fldId,OrganId)
                    .Select(q => new OBJ_Commision()
                    {
                        fldID = q.fldid,
                        fldName = q.fldName,
                        fldO_postEjraee_Title = q.fldO_postEjraee_title,
                        fldFatherName = q.fldFatherName,
                    }).ToList();
                return k;
            }
        }
        #endregion
        
    }
}