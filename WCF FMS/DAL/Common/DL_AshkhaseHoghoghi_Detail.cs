using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_AshkhaseHoghoghi_Detail
    {
        #region Detail
        public OBJ_AshkhaseHoghoghi_Detail Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblAshkhaseHoghoghi_DetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_AshkhaseHoghoghi_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAddress = q.fldAddress,
                        fldAshkhaseHoghoghiId = q.fldAshkhaseHoghoghiId,
                        fldCodEghtesadi = q.fldCodEghtesadi,
                        fldCodePosti = q.fldCodePosti,
                        fldShomareTelephone = q.fldShomareTelephone,
                        fldName = q.fldName,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldShomareSabt = q.fldShomareSabt,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldTypeShakhsName = q.fldTypeShakhsName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AshkhaseHoghoghi_Detail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblAshkhaseHoghoghi_DetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_AshkhaseHoghoghi_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAddress = q.fldAddress,
                        fldAshkhaseHoghoghiId = q.fldAshkhaseHoghoghiId,
                        fldCodEghtesadi = q.fldCodEghtesadi,
                        fldCodePosti = q.fldCodePosti,
                        fldShomareTelephone = q.fldShomareTelephone,
                        fldName = q.fldName,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldShomareSabt = q.fldShomareSabt,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldTypeShakhsName = q.fldTypeShakhsName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhaseHoghoghi_DetailInsert(AshkhaseHoghoghiId, CodEghtesadi, Address, CodePosti, ShomareTelephone, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhaseHoghoghi_DetailUpdate(Id, AshkhaseHoghoghiId, CodEghtesadi, Address, CodePosti, ShomareTelephone, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhaseHoghoghi_DetailDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int AshkhaseHoghoghiId, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblAshkhaseHoghoghi_DetailSelect("fldAshkhaseHoghoghiId", AshkhaseHoghoghiId.ToString(), 0).Any();

                }
                else
                {
                    var query = p.spr_tblAshkhaseHoghoghi_DetailSelect("fldAshkhaseHoghoghiId", AshkhaseHoghoghiId.ToString(), 0).FirstOrDefault();
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