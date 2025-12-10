using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_Weighbridge
    {
        #region Detail
        public OBJ_Weighbridge Detail(int id)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var k = p.spr_tblWeighbridgeSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_Weighbridge
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldIP = q.fldIP,
                        fldAshkhasHoghoghiId = q.fldAshkhasHoghoghiId,
                        fldAddress = q.fldAddress,
                        fldNameAshkhasHoghoghi = q.fldNameAshkhasHoghoghi,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldPassword = q.fldPassword
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Weighbridge> Select(string FieldName, string FilterValue, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblWeighbridgeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Weighbridge()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldIP = q.fldIP,
                        fldAshkhasHoghoghiId = q.fldAshkhasHoghoghiId,
                        fldAddress = q.fldAddress,
                        fldNameAshkhasHoghoghi = q.fldNameAshkhasHoghoghi,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldPassword = q.fldPassword
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldAshkhasHoghoghiId, string fldName, string fldAddress, string fldPassword, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblWeighbridgeInsert(fldAshkhasHoghoghiId, fldName, fldAddress, userId, Desc, IP,fldPassword);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldAshkhasHoghoghiId, string fldName, string fldAddress, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblWeighbridgeUpdate(fldId, fldAshkhasHoghoghiId, fldName, fldAddress, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblWeighbridgeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (WeighEntities p = new WeighEntities())
            {
                var Parametr = p.spr_tblParametrBaskoolValueSelect("fldBaskoolId", id.ToString(), 0).FirstOrDefault();
                var Arze = p.spr_tblArzeSelect("fldBaskoolId", id.ToString(),0, 0).FirstOrDefault();
                if (Parametr != null || Arze!=null)
                    q = true;
            }
            return q;
        }
        #endregion

        #region UpdatePassBaskool
        public string UpdatePassBaskool(int fldId, string Password, int userId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_UpdatePassBaskool(fldId, Password, userId);
                return "تغییر رمز با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}