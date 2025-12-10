using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_ShomareHesabPasAndaz
    {
        #region Detail
        public OBJ_ShomareHesabPasAndaz Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblShomareHesabPasAndazSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_ShomareHesabPasAndaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankFixId = q.fldBankFixId,
                        fldBankName = q.fldBankName,
                        fldName = q.fldName,
                        fldPersonalId = q.fldPersonalId,
                        fldShomareHesabKarfarmaId = q.fldShomareHesabKarfarmaId,
                        fldShomareHesabPersonalId = q.fldShomareHesabPersonalId,
                        fldShomareHesabPersonal=q.fldShomareHesabPersonal,
                        fldShomareHesabKarfarma = q.fldShomareHesabKarfarma
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabPasAndaz> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblShomareHesabPasAndazSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_ShomareHesabPasAndaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankFixId = q.fldBankFixId,
                        fldBankName = q.fldBankName,
                        fldName = q.fldName,
                        fldPersonalId = q.fldPersonalId,
                        fldShomareHesabKarfarmaId = q.fldShomareHesabKarfarmaId,
                        fldShomareHesabPersonalId = q.fldShomareHesabPersonalId,
                        fldShomareHesabPersonal = q.fldShomareHesabPersonal,
                        fldShomareHesabKarfarma = q.fldShomareHesabKarfarma
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert( int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblShomareHesabPasAndazInsert( ShomareHesabPersonalId, ShomareHesabKarfarmaId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblShomareHesabPasAndazUpdate(Id, ShomareHesabPersonalId, ShomareHesabKarfarmaId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblShomareHesabPasAndazDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}