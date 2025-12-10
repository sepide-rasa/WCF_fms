using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_DocumentDesc
    {
        #region Detail
        public OBJ_DocumentDesc Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblDocumentDescSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_DocumentDesc
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDocDesc = q.fldDocDesc,
                        fldName = q.fldName,
                        fldFlag = q.fldFlag,
                        fldFlagName = q.fldFlagName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DocumentDesc> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblDocumentDescSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DocumentDesc()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDocDesc = q.fldDocDesc,
                        fldName = q.fldName,
                        fldFlag = q.fldFlag,
                        fldFlagName = q.fldFlagName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name, string DocDesc,bool flag, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentDescInsert(Name, DocDesc, Desc, flag, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, string DocDesc, bool flag, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentDescUpdate(Id, Name, DocDesc, Desc,flag, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentDescDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name, int Id, bool flag)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblDocumentDescSelect("fldName", Name, 0).Where(l=>l.fldFlag==flag).Any();

                }
                else
                {
                    var query = p.spr_tblDocumentDescSelect("fldName", Name, 0).Where(l => l.fldFlag == flag).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region GetParamDocumentDesc
        public List<OBJ_ParamDocumentDesc> GetParamDocumentDesc(string DocDesc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_GetParamDocumentDesc(DocDesc)
                    .Select(q => new OBJ_ParamDocumentDesc()
                    {
                        param = q.param,
                        Value = q.Value
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}