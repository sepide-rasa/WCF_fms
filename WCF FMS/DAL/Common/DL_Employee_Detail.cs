using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_Employee_Detail
    {
        #region Detail
        public OBJ_Employee_Detail Detail(int id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblEmployee_DetailSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_Employee_Detail
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldCodemeli = q.fldCodemeli,
                        fldAddress = q.fldAddress,
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        fldCodePosti = q.fldCodePosti,
                        fldEmployeeId = q.fldEmployeeId,
                        fldFatherName = q.fldFatherName,
                        fldFileId = q.fldFileId,
                        fldJensiyat = q.fldJensiyat,
                        fldMadrakId = q.fldMadrakId,
                        fldMahalSodoorId = q.fldMahalSodoorId,
                        fldMahalTavalodId = q.fldMahalTavalodId,
                        fldMeliyat = q.fldMeliyat,
                        fldNezamVazifeId = q.fldNezamVazifeId,
                        fldReshteId = q.fldReshteId,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldTaaholId = q.fldTaaholId,
                        fldTarikhSodoor = q.fldTarikhSodoor,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldMobile = q.fldMobile,
                        fldTypeShakhsName = q.fldTypeShakhsName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Employee_Detail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblEmployee_DetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Employee_Detail()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldCodemeli = q.fldCodemeli,
                        fldAddress = q.fldAddress,
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        fldCodePosti = q.fldCodePosti,
                        fldEmployeeId = q.fldEmployeeId,
                        fldFatherName = q.fldFatherName,
                        fldFileId = q.fldFileId,
                        fldJensiyat = q.fldJensiyat,
                        fldMadrakId = q.fldMadrakId,
                        fldMahalSodoorId = q.fldMahalSodoorId,
                        fldMahalTavalodId = q.fldMahalTavalodId,
                        fldMeliyat = q.fldMeliyat,
                        fldNezamVazifeId = q.fldNezamVazifeId,
                        fldReshteId = q.fldReshteId,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldTaaholId = q.fldTaaholId,
                        fldTarikhSodoor = q.fldTarikhSodoor,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldTypeShakhsName = q.fldTypeShakhsName,
                        fldMobile = q.fldMobile,
                        fldTel = q.fldTel
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat, string fldTarikhTavalod,
            Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId, Nullable<int> fldReshteId,
            byte[] fldFile, string fldPassvand, string fldSh_Shenasname, Nullable<int> fldMahalTavalodId,
            Nullable<int> fldMahalSodoorId, string fldTarikhSodoor, string fldAddress, string fldCodePosti,
            Nullable<bool> fldMeliyat, int fldUserId, string fldDesc,string fldTel,string fldMobile)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblEmployee_DetailInsert(fldEmployeeId, fldFatherName, fldJensiyat, fldTarikhTavalod, fldMadrakId, fldNezamVazifeId, fldTaaholId, fldReshteId, fldFile, fldPassvand, fldSh_Shenasname, fldMahalTavalodId
                    , fldMahalSodoorId, fldTarikhSodoor, fldAddress, fldCodePosti, fldMeliyat, fldUserId, fldDesc, fldTel, fldMobile);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat, string fldTarikhTavalod,
            Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId, Nullable<int> fldReshteId,
            Nullable<int> fldFileId, byte[] fldFile, string fldPasvand, string fldSh_Shenasname, Nullable<int> fldMahalTavalodId,
            Nullable<int> fldMahalSodoorId, string fldTarikhSodoor, string fldAddress, string fldCodePosti, Nullable<bool> fldMeliyat,
            int fldUserId, string fldDesc,string fldTel,string fldMobile)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblEmployee_DetailUpdate(fldId, fldEmployeeId, fldFatherName, fldJensiyat, fldTarikhTavalod, fldMadrakId, fldNezamVazifeId, fldTaaholId, fldReshteId, fldFileId, fldFile
                    , fldPasvand, fldSh_Shenasname, fldMahalTavalodId, fldMahalSodoorId, fldTarikhSodoor, fldAddress, fldCodePosti, fldMeliyat, fldUserId, fldDesc, fldTel, fldMobile);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblEmployee_DetailDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int EmployeeId, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblEmployee_DetailSelect("fldEmployeeId", EmployeeId.ToString(), 0).Any();

                }
                else
                {
                    var query = p.spr_tblEmployee_DetailSelect("fldEmployeeId", EmployeeId.ToString(), 0).FirstOrDefault();
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