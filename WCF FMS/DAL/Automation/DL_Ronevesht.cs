using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_Ronevesht
    {
        #region Detail
        public OBJ_Ronevesht Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblRoneveshtSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Ronevesht()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldid = q.fldid,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldAshkhasHoghoghiTitlesId = q.fldAshkhasHoghoghiTitlesId,
                        fldCommisionId = q.fldCommisionId,
                        fldAssignmentTypeId = q.fldAssignmentTypeId,
                        fldText = q.fldText,
                        fldName = q.fldName,
                        fldId_Type = q.fldId_Type
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Ronevesht> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblRoneveshtSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Ronevesht()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldid = q.fldid,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldAshkhasHoghoghiTitlesId = q.fldAshkhasHoghoghiTitlesId,
                        fldCommisionId = q.fldCommisionId,
                        fldAssignmentTypeId = q.fldAssignmentTypeId,
                        fldText = q.fldText,
                        fldName = q.fldName,
                        fldId_Type = q.fldId_Type
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long fldLetterId, int? fldAshkhasHoghoghiId, int? fldCommisionId, int fldAssignmentTypeId, string fldText, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblRoneveshtInsert(fldLetterId, fldAshkhasHoghoghiId, fldCommisionId, fldAssignmentTypeId, fldText, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long fldLetterId, int? fldAshkhasHoghoghiId, int? fldCommisionId, int fldAssignmentTypeId, string fldText, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblRoneveshtUpdate(Id, fldLetterId, fldAshkhasHoghoghiId, fldCommisionId, fldAssignmentTypeId, fldText, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldNAme,long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblRoneveshtDelete(FieldNAme,Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}