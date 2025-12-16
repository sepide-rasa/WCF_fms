using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_ItemsMablgh
    {
        #region Detail
        public OBJ_ItemsMablgh Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblItemsMablghSelect("fldId", id.ToString(), "", 1)
                    .Select(q => new OBJ_ItemsMablgh
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldHeaderId = q.fldHeaderId,
                        fldMablagh = q.fldMablagh,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldItemHoghughiTitle = q.fldItemHoghughiTitle,
                        fldPercentW_H = q.fldPercentW_H,
                        fldPercentChild = q.fldPercentChild,
                        fldCount = q.fldCount
                    }).FirstOrDefault();
                return k;
            }
        }

        #endregion
        #region Select
        public List<OBJ_ItemsMablgh> Select(string FieldName, string FilterValue, string FilterValue2,  int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblItemsMablghSelect(FieldName, FilterValue, FilterValue2,  h)
                    .Select(q => new OBJ_ItemsMablgh()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldHeaderId = q.fldHeaderId,
                        fldMablagh = q.fldMablagh,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldItemHoghughiTitle = q.fldItemHoghughiTitle,
                        fldPercentW_H = q.fldPercentW_H,
                        fldPercentChild = q.fldPercentChild,
                        fldCount = q.fldCount
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int HeaderId, int ItemsHoghughiId, int Mablagh,decimal PercentW_H,decimal PercentChild, byte Count, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblItemsMablghInsert(HeaderId, ItemsHoghughiId, Mablagh, PercentW_H, PercentChild,Count, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int HeaderId, int ItemsHoghughiId, int Mablagh, decimal PercentW_H, decimal PercentChild, byte Count, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblItemsMablghUpdate(Id, HeaderId, ItemsHoghughiId, Mablagh, PercentW_H, PercentChild, Count, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblItemsMablghDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int Id, int ItemsHoghughiId, int HeaderId)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblItemsMablghSelect("CheckUnique", HeaderId.ToString(), ItemsHoghughiId.ToString(), 1).Any();
                }
                else
                {
                    var query = p.spr_tblItemsMablghSelect("CheckUnique", HeaderId.ToString(), ItemsHoghughiId.ToString(), 1).FirstOrDefault();
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