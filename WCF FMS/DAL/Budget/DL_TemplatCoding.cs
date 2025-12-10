using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_TemplatCoding
    {
        #region Detail
        public OBJ_TemplatCoding Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblTemplatCodingSelect("fldId", id.ToString(),"", OrganId, 1)
                    .Select(q => new OBJ_TemplatCoding
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldLevelId = q.fldLevelId,
                        fldOrganId = q.fldOrganId,
                        fldStrhid = q.fldStrhid,
                        fldName = q.fldName,
                        fldPCod = q.fldPCod,
                        fldCode = q.fldCode,
                        fldCodingLevelId = q.fldCodingLevelId,
                        fldIp = q.fldIp,
                        fldTemplatNameId = q.fldTemplatNameId,
                        fldNameTampalte = q.fldNameTampalte,
                        fldNameCodingLevel = q.fldNameCodingLevel
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TemplatCoding> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblTemplatCodingSelect(FieldName, FilterValue, FilterValue2, OrganId, h)
                    .Select(q => new OBJ_TemplatCoding()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldLevelId = q.fldLevelId,
                        fldOrganId = q.fldOrganId,
                        fldStrhid = q.fldStrhid,
                        fldName = q.fldName,
                        fldPCod = q.fldPCod,
                        fldCode = q.fldCode,
                        fldCodingLevelId = q.fldCodingLevelId,
                        fldIp = q.fldIp,
                        fldTemplatNameId = q.fldTemplatNameId,
                        fldNameTampalte = q.fldNameTampalte,
                        fldNameCodingLevel = q.fldNameCodingLevel
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int? PID, string fldName, string fldPCod, int fldTemplatNameId, string fldCode, int fldCodingLevelId, int OrganId, int userId, string Desc, string Ip)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTemplatCodingInsert(PID, fldName, fldPCod, fldTemplatNameId, fldCode, fldCodingLevelId, Desc, Ip, userId, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldTemplatNameId, string fldCode, int fldCodingLevelId, int OrganId, int userId, string Desc, string Ip)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTemplatCodingUpdate(Id, fldName, fldTemplatNameId, fldCode, fldCodingLevelId, Desc, Ip, userId, OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTemplatCodingDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int fldTemplatNameId, string fldCode, int OrganId, int Id)
        {
            bool q = false;
            using (BudgetEntities p = new BudgetEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblTemplatCodingSelect("fldCode", fldCode, "", OrganId, 0).Where(l => l.fldTemplatNameId == fldTemplatNameId).Any();

                }
                else
                {
                    var query = p.spr_tblTemplatCodingSelect("fldCode", fldCode, "", OrganId, 0).Where(l => l.fldTemplatNameId == fldTemplatNameId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckValidCodeBudje
        public List<OBJ_CheckValidCodeBudje> CheckValidCodeBudje(string Code, string PCode, int fldId, int TempNameId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.CheckValidCodeBudje(Code, PCode, fldId, TempNameId)
                    .Select(q => new OBJ_CheckValidCodeBudje()
                    {
                        fldValid = q.fldValid,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region GetDefaultCodeBudje
        public List<OBJ_DefaultCode> GetDefaultCodeBudje(string PCode, int TempNameId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.GetDefaultCodeBudje(PCode, TempNameId)
                    .Select(q => new OBJ_DefaultCode()
                    {
                        fldCode = q.fldCode,
                        LevelId = q.LevelId,
                        fldLevelName = q.fldLevelName,
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}