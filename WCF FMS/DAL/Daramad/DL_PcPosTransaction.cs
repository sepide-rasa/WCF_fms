using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PcPosTransaction
    {
        #region Detail
        public OBJ_PcPosTransaction Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPcPosTransactionSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PcPosTransaction()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFishId = q.fldFishId,
                        fldPrice = q.fldPrice,
                        fldShGhabz = q.fldShGhabz,
                        fldShPardakht = q.fldShPardakht,
                        fldStatus = q.fldStatus,
                        fldTrackingCode = q.fldTrackingCode,
                        fldCardNumber = q.fldCardNumber,
                        fldNahvePardakht = q.fldNahvePardakht,
                        fldSerialNumber = q.fldSerialNumber,
                        fldTarikh = q.fldTarikh,
                        fldTerminalCode = q.fldTerminalCode
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PcPosTransaction> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPcPosTransactionSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PcPosTransaction()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFishId = q.fldFishId,
                        fldPrice = q.fldPrice,
                        fldShGhabz = q.fldShGhabz,
                        fldShPardakht = q.fldShPardakht,
                        fldStatus = q.fldStatus,
                        fldTrackingCode = q.fldTrackingCode,
                        fldCardNumber = q.fldCardNumber,
                        fldNahvePardakht = q.fldNahvePardakht,
                        fldSerialNumber = q.fldSerialNumber,
                        fldTarikh = q.fldTarikh,
                        fldTerminalCode = q.fldTerminalCode
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int FishId, long Price, bool Status, string TrackingCode, string ShGhabz, string ShPardakht, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId",typeof(int));
                p.spr_tblPcPosTransactionInsert(id, FishId, Price, Status, TrackingCode, ShGhabz, ShPardakht, UserId, Desc,TerminalCode,SerialNumber,CardNumber,Tarikh);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int FishId, long Price, bool Status, string TrackingCode, string ShGhabz, string ShPardakht, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosTransactionUpdate(Id, FishId, Price, Status, TrackingCode, ShGhabz, ShPardakht, UserId, Desc, TerminalCode, SerialNumber, CardNumber, Tarikh);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosTransactionDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region PcPosTransactionUpdate_Status
        public string PcPosTransactionUpdate_Status(int Id, string TrackingCode, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_PcPosTransactionUpdate_Status(Id, TrackingCode, Desc, TerminalCode, SerialNumber, CardNumber, Tarikh);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}