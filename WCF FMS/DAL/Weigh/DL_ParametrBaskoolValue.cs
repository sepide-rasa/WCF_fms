using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_ParametrBaskoolValue
    {
        #region Select
        public List<OBJ_ParametrBaskoolValue> Select(string FieldName, string FilterValue, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblParametrBaskoolValueSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ParametrBaskoolValue()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldParametrBaskoolId = q.fldParametrBaskoolId,
                        fldIP = q.fldIP,
                        fldBaskoolId = q.fldBaskoolId,
                        fldValue = q.fldValue,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldParametrBaskoolId, int fldBaskoolId, string fldValue,  int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {

                p.spr_tblParametrBaskoolValueInsert(fldParametrBaskoolId, fldBaskoolId, fldValue, userId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldParametrBaskoolId, int fldBaskoolId, string fldValue, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblParametrBaskoolValueUpdate(fldId, fldParametrBaskoolId, fldBaskoolId, fldValue, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblParametrBaskoolValueDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region SelectBaskoolParametr_Value
        public List<OBJ_BaskoolParametr_Value> SelectBaskoolParametr_Value(int BaskoolId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_SelectBaskoolParametr_Value(BaskoolId)
                    .Select(q => new OBJ_BaskoolParametr_Value()
                    {
                        fldid = q.fldid,
                        fldFaName = q.fldFaName,
                        fldEnName = q.fldEnName,
                        fldParam_ValueId = q.fldParam_ValueId,
                        fldValue = q.fldValue,
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}