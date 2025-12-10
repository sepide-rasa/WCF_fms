using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Fiscal_Header
    {
        #region Detail
        public OBJ_Fiscal_Header Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFiscal_HeaderSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_Fiscal_Header()
                    {
                        fldDate = q.fldDate,
                        fldDateOfIssue = q.fldDateOfIssue,
                        fldDesc = q.fldDesc,
                        fldEffectiveDate = q.fldEffectiveDate,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Fiscal_Header> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFiscal_HeaderSelect(FieldName, FilterValue, FilterValue2, h)
                    .Select(q => new OBJ_Fiscal_Header()
                    {
                        fldDate = q.fldDate,
                        fldDateOfIssue = q.fldDateOfIssue,
                        fldDesc = q.fldDesc,
                        fldEffectiveDate = q.fldEffectiveDate,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(string EffectiveDate, string DateOfIssue, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblFiscal_HeaderInsert(Id, EffectiveDate, DateOfIssue, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string EffectiveDate, string DateOfIssue, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_HeaderUpdate(Id, EffectiveDate, DateOfIssue, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_HeaderDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var a = p.spr_tblFiscalTitleSelect("fldFiscalHeaderlId", id.ToString(), 1).FirstOrDefault();
                var f = p.spr_tblMohasebat_PersonalInfoSelect("CheckFiscalHeaderId", id.ToString(),0, 1).FirstOrDefault();
                if (a != null || f != null)
                    q = true;
                return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string EffectiveDate, string DateOfIssue, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblFiscal_HeaderSelect("EffectiveDate_DateOfIssue", EffectiveDate, DateOfIssue, 0).Any();

                }
                else
                {
                    var query = p.spr_tblFiscal_HeaderSelect("EffectiveDate_DateOfIssue", EffectiveDate, DateOfIssue, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
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