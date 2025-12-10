using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PardakhtFile
    {
        #region Detail
        public OBJ_PardakhtFile Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPardakhtFileSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PardakhtFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankId=q.fldBankId,
                        fldDateSendFile=q.fldDateSendFile,
                        fldFileName = q.fldFileName,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PardakhtFile> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPardakhtFileSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PardakhtFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankId = q.fldBankId,
                        fldDateSendFile = q.fldDateSendFile,
                        fldFileName = q.fldFileName,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int BankId, string FileName, string DateSendFile, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id=new System.Data.Entity.Core.Objects.ObjectParameter("fldId",typeof(int));
                p.spr_tblPardakhtFileInsert(id,BankId,FileName,DateSendFile,UserId, Desc);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int BankId, string FileName, string DateSendFile, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFileUpdate(Id, BankId, FileName, DateSendFile, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFileDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}