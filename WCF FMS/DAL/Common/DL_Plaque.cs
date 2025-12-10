using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_Plaque
    {
        #region Detail
        public OBJ_Plaque Detail(int id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblPlaqueSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_Plaque
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldSerialPlaque = q.fldSerialPlaque,
                        fldIP = q.fldIP,
                        fldPlaque = q.fldPlaque,
                        fldSerial_Plaque = q.fldSerial_Plaque
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Plaque> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblPlaqueSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Plaque()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldSerialPlaque = q.fldSerialPlaque,
                        fldIP = q.fldIP,
                        fldPlaque = q.fldPlaque,
                        fldSerial_Plaque = q.fldSerial_Plaque
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, int userId, string Desc, string IP)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblPlaqueInsert(fldSerialPlaque, harf, fldPlaque2, fldPlaque3, userId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, int userId, string Desc, string IP)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblPlaqueUpdate(fldId, fldSerialPlaque, harf, fldPlaque2, fldPlaque3, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblPlaqueDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertPlaque_WebService
        public int InsertPlaque_WebService(string Harf,string Plaque2,string Plaque3,byte Serial)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblPlaqueInsert_WebService(Id,Harf, Plaque2,Plaque3,Serial, "");
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
    }
}