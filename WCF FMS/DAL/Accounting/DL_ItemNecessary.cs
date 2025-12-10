using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_ItemNecessary
    {
        #region Detail
        public OBJ_ItemNecessary Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblItemNecessarySelect("fldId", id.ToString(),"",1)
                    .Select(q => new OBJ_ItemNecessary
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldNameItem = q.fldNameItem,
                        fldMahiyatId = q.fldMahiyatId,
                        fldTypeHesabId = q.fldTypeHesabId,
                        fldNameTypeHesab = q.fldNameTypeHesab,
                        fldMahiyat_GardeshId = q.fldMahiyat_GardeshId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ItemNecessary> Select(string FieldName, string FilterValue,string FilterValue2, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblItemNecessarySelect(FieldName, FilterValue,FilterValue2, h)
                    .Select(q => new OBJ_ItemNecessary()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldNameItem = q.fldNameItem,
                        fldMahiyatId = q.fldMahiyatId,
                        fldTypeHesabId = q.fldTypeHesabId,
                        fldNameTypeHesab = q.fldNameTypeHesab,
                        fldMahiyat_GardeshId = q.fldMahiyat_GardeshId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(Nullable<int> PID, string NameItem, int MahiyatId,int? Mahiyat_GardeshId, byte fldTypeHesabId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblItemNecessaryInsert(PID, NameItem, MahiyatId, fldTypeHesabId, Desc, IP, UserId, Mahiyat_GardeshId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string NameItem, int MahiyatId,int? Mahiyat_GardeshId, byte fldTypeHesabId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblItemNecessaryUpdate(Id, NameItem, MahiyatId, fldTypeHesabId, Desc, IP, UserId, Mahiyat_GardeshId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblItemNecessaryDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdatePID_ItemNecessary
        public string UpdatePID_ItemNecessary(int ChildId, int ParentId, int UserId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_UpdatePID_ItemNecessary(ChildId,ParentId, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string NameItem, int Id)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblItemNecessarySelect("fldNameItem", NameItem,"", 0).Any();

                }
                else
                {
                    var query = p.spr_tblItemNecessarySelect("fldNameItem", NameItem,"", 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (AccountingEntities m = new AccountingEntities())
            {
                var Template = m.spr_tblTemplateCodingSelect("fldItemId", id.ToString(), "",0,"", 0).FirstOrDefault();
                if (Template != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}