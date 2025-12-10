using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.DAL.Chek
{
    public class DL_OlgoCheck
    {
        #region Detail
        public OBJ_OlgoCheck Detail(int Id, int OrganId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblOlgoCheckSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_OlgoCheck()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldIdBank = q.fldIdBank,
                        fldIdFile = q.fldIdFile,
                        fldBankName = q.fldBankName,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_OlgoCheck> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblOlgoCheckSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_OlgoCheck()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldIdBank = q.fldIdBank,
                        fldIdFile = q.fldIdFile,
                        fldBankName = q.fldBankName,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, byte[] File, string Pasvand, int BankId, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblOlgoCheckInsert(File, Pasvand, BankId, UserId, Desc, Title,OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, byte[] File, string Pasvand, int FileId, int BankId, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblOlgoCheckUpdate(Id, File, Pasvand, FileId, BankId, UserId, Desc, Title,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblOlgoCheckDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (ChekEntities p = new ChekEntities())
            {
                var daste_Ch = p.spr_tblDasteCheckSelect("fldIdOlgoChek_CheckDelete", Id.ToString(),0, 0).FirstOrDefault();
                if (daste_Ch != null)
                {
                    q = true;
                }
            }
            return q;
        }
        #endregion
    }
}