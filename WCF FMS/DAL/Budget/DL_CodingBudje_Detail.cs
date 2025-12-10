using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_CodingBudje_Detail
    {
        #region Detail
        public OBJ_CodingBudje_Detail Detail(int id)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblCodingBudje_DetailsSelect("fldId", id.ToString(),"","", 1)
                    .Select(q => new OBJ_CodingBudje_Detail
                    {
                        fldId = q.fldCodeingBudjeId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldLevelId = q.fldLevelId,
                        fldIP = q.fldIp,
                        fldYear = q.fldYear,
                        fldStrhid = q.fldStrhid,
                        fldHeaderId = q.fldHeaderId,
                        fldTitle = q.fldTitle,
                        fldCode = q.fldCode,
                        fldBudCode = q.fldBudCode,
                        fldEtebarType = q.fldEtebarType,
                        fldEtebarTypeId = q.fldEtebarTypeId,
                        fldMasrafTTitle = q.fldMasrafTTitle,
                        fldMasrafTypeId = q.fldMasrafTypeId,
                        fldOldId = q.fldOldId,
                        fldTarh_KhedmatTypeId = q.fldTarh_KhedmatTypeId,
                        fldNameLevel = q.fldNameLevel,
                        fldPcode = q.fldPcode,
                        fldCodeingLevelId = q.fldCodeingLevelId,
                        fldCodeBarname = q.fldCodeBarname,
                        fldCodeMamooriyat = q.fldCodeMamooriyat,
                        fldTitleBarname = q.fldTitleBarname,
                        fldTitleMamooriyat = q.fldTitleMamooriyat
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodingBudje_Detail> Select(string FieldName, string FilterValue, string FilterValue2,string FilterValue3, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblCodingBudje_DetailsSelect(FieldName, FilterValue, FilterValue2,FilterValue3, h)
                    .Select(q => new OBJ_CodingBudje_Detail()
                    {
                        fldId = q.fldCodeingBudjeId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldLevelId = q.fldLevelId,
                        fldIP = q.fldIp,
                        fldYear = q.fldYear,
                        fldStrhid = q.fldStrhid,
                        fldHeaderId = q.fldHeaderId,
                        fldTitle = q.fldTitle,
                        fldCode = q.fldCode,
                        fldBudCode = q.fldBudCode,
                        fldEtebarType = q.fldEtebarType,
                        fldEtebarTypeId = q.fldEtebarTypeId,
                        fldMasrafTTitle = q.fldMasrafTTitle,
                        fldMasrafTypeId = q.fldMasrafTypeId,
                        fldOldId = q.fldOldId,
                        fldTarh_KhedmatTypeId = q.fldTarh_KhedmatTypeId,
                        fldNameLevel = q.fldNameLevel,
                        fldPcode = q.fldPcode,
                        fldCodeingLevelId=q.fldCodeingLevelId,
                        fldCodeBarname=q.fldCodeBarname,
                        fldCodeMamooriyat=q.fldCodeMamooriyat,
                        fldTitleBarname=q.fldTitleBarname,
                        fldTitleMamooriyat=q.fldTitleMamooriyat
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int? PID,  int HeaderId, string Title, string Code,  byte? fldKhedmat_Tarh, byte? fldEtebarTypeId, byte? fldTypeMasrafId,int fldCodeingLevelId,   int userId,  string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingBudje_DetailsInsert(PID, HeaderId, Title, Code, fldKhedmat_Tarh, fldEtebarTypeId, fldTypeMasrafId,fldCodeingLevelId, IP, userId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int HeaderId, string Title, string Code, byte? fldKhedmat_Tarh,  byte? fldEtebarTypeId, byte? fldTypeMasrafId,int fldCodeingLevelId, int userId, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingBudje_DetailsUpdate(Id, HeaderId, Title, Code, fldKhedmat_Tarh, fldEtebarTypeId, fldTypeMasrafId, fldCodeingLevelId,IP, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingBudje_DetailsDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CopyFromTemplateCodingToCodingBudje
        public string CopyFromTemplateCodingToCodingBudje(int HeaderId, int organId, int userId, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.CopyFromTemplateCodingToCodingBudje(HeaderId, userId,organId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckValidCode_CodingDetailBudje
        public List<OBJ_CheckValidCodeBudje> CheckValidCode_CodingDetailBudje(int HeaderId, string Code, string PCode, int fldId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.CheckValidCode_CodingDetailBudje(HeaderId,Code, PCode, fldId)
                    .Select(q => new OBJ_CheckValidCodeBudje()
                    {
                        fldValid = q.fldValid,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region GetDefaultCodeBudje_Coding
        public List<OBJ_DefaultCode> GetDefaultCodeBudje_Coding(int HeaderId, string PCode)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.GetDefaultCodeBudje_Coding(HeaderId,PCode)
                    .Select(q => new OBJ_DefaultCode()
                    {
                        fldCode = q.fldCode,
                        LevelId = q.LevelId,
                        fldLevelName = q.fldLevelName,
                        NodLevel = q.NodLevel,
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region CopyFromLastYear
        public string CopyCodingDetail(int HeaderId,  int userId, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_CopyCodingDetail(HeaderId,IP, userId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}