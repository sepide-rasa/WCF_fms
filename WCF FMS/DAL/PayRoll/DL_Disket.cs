using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Disket
    {
        #region Detail
        public OBJ_Disket Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDisketSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Disket()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldEdit = q.fldEdit,
                        fldId = q.fldId,
                        fldJam = q.fldJam,
                        fldMarhale = q.fldMarhale,
                        fldTarikh = q.fldTarikh,
                        fldTedad = q.fldTedad,
                        fldTimeEdit = q.fldTimeEdit,
                        fldType = q.fldType,
                        fldTypePardakht = q.fldTypePardakht,
                        fldUserId = q.fldUserId,
                        fldFileId = q.fldFileId,
                        fldNameFile = q.fldNameFile,
                        fldOrganCode = q.fldOrganCode,
                        fldShobeCode = q.fldShobeCode,
                        fldBankFixId=q.fldBankFixId,
                        fldNameShobe = q.fldNameShobe,
                        fldNameTypePardakht = q.fldNameTypePardakht
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Disket> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDisketSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Disket()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldEdit = q.fldEdit,
                        fldId = q.fldId,
                        fldJam = q.fldJam,
                        fldMarhale = q.fldMarhale,
                        fldTarikh = q.fldTarikh,
                        fldTedad = q.fldTedad,
                        fldTimeEdit = q.fldTimeEdit,
                        fldType = q.fldType,
                        fldTypePardakht = q.fldTypePardakht,
                        fldUserId = q.fldUserId,
                        fldFileId = q.fldFileId,
                        fldNameFile = q.fldNameFile,
                        fldOrganCode = q.fldOrganCode,
                        fldShobeCode = q.fldShobeCode,
                        fldBankFixId = q.fldBankFixId,
                        fldNameShobe = q.fldNameShobe,
                        fldNameTypePardakht = q.fldNameTypePardakht
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht, string ShobeCode, string OrganCode, byte[] File, string Pasvand, string NameFile,int BankFixId,string NameShobe, int UserId, string Desc,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblDisketInsert(Id, Tarikh, Tedad, Type, Jam, TypePardakht, ShobeCode, OrganCode, File, Pasvand, NameFile, BankFixId, NameShobe, UserId, Desc, OrganId);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht, string ShobeCode, string OrganCode, int FielId, byte[] File, string Pasvand, string NameFile, int BankFixId, string NameShobe, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDisketUpdate(Id, Tarikh, Tedad, Type, Jam, TypePardakht, ShobeCode, OrganCode, FielId, File, Pasvand, NameFile, BankFixId, NameShobe, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDisketDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}