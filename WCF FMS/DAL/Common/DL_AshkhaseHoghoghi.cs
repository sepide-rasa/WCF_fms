using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_AshkhaseHoghoghi
    {
        #region Detail
        public OBJ_AshkhaseHoghoghi Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblAshkhaseHoghoghiSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_AshkhaseHoghoghi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldShomareSabt = q.fldShomareSabt,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldTypeShakhsName = q.fldTypeShakhsName,
                        fldSayer = q.fldSayer,
                        fldSayerName = q.fldSayerName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AshkhaseHoghoghi> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblAshkhaseHoghoghiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_AshkhaseHoghoghi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldShomareSabt = q.fldShomareSabt,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldTypeShakhsName = q.fldTypeShakhsName,
                        fldSayer = q.fldSayer,
                        fldSayerName = q.fldSayerName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(string fldShenaseMelli, string fldName, string fldShomareSabt,byte TypeShakhs,byte Sayer, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("AshkhasId",typeof(int));
                p.spr_tblAshkhaseHoghoghiInsert(fldShenaseMelli, fldName, fldShomareSabt, UserId, Desc, id, TypeShakhs,Sayer);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldShenaseMelli, string fldName, string fldShomareSabt, byte TypeShakhs,byte Sayer, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhaseHoghoghiUpdate(Id, fldShenaseMelli, fldName, fldShomareSabt, UserId, Desc, TypeShakhs,Sayer);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhaseHoghoghiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string fldShenaseMelli, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblAshkhaseHoghoghiSelect("fldShenaseMelli", fldShenaseMelli, 0).Any();

                }
                else
                {
                    var query = p.spr_tblAshkhaseHoghoghiSelect("fldShenaseMelli", fldShenaseMelli, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                q = m.spr_tblAshkhasSelect("fldHoghoghiId", id.ToString(), "", 0).Any();
            }
            return q;
        }
        #endregion
        #region CheckRepeatedName
        public bool CheckRepeatedName(string fldName, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblAshkhaseHoghoghiSelect("fldName", fldName, 0).Any();

                }
                else
                {
                    var query = p.spr_tblAshkhaseHoghoghiSelect("fldName", fldName, 0).FirstOrDefault();
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