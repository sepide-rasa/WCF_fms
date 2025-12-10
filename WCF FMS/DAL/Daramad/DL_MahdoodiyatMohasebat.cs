using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_MahdoodiyatMohasebat
    {
        #region Detail
        public OBJ_MahdoodiyatMohasebat Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMahdoodiyatMohasebatSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MahdoodiyatMohasebat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAzTarikh = q.fldAzTarikh,
                        fldNoeAshkhas = q.fldNoeAshkhas,
                        fldNoeCodeDaramad = q.fldNoeCodeDaramad,
                        fldNoeKarbar = q.fldNoeKarbar,
                        fldStatus = q.fldStatus,
                        fldTatarikh = q.fldTatarikh,
                        fldNoeKarbarName = q.fldNoeKarbarName,
                        fldNoeCodeDaramadName = q.fldNoeCodeDaramadName,
                        fldNoeAshkhasName = q.fldNoeAshkhasName,
                        fldStatusName = q.fldStatusName,
                        fldTitle = q.fldTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MahdoodiyatMohasebat> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMahdoodiyatMohasebatSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MahdoodiyatMohasebat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAzTarikh = q.fldAzTarikh,
                        fldNoeAshkhas = q.fldNoeAshkhas,
                        fldNoeCodeDaramad = q.fldNoeCodeDaramad,
                        fldNoeKarbar = q.fldNoeKarbar,
                        fldStatus = q.fldStatus,
                        fldTatarikh = q.fldTatarikh,
                        fldNoeKarbarName = q.fldNoeKarbarName,
                        fldNoeCodeDaramadName = q.fldNoeCodeDaramadName,
                        fldNoeAshkhasName = q.fldNoeAshkhasName,
                        fldStatusName = q.fldStatusName,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(string Title,string AzTarikh, string Tatarikh, bool NoeKarbar, bool NoeCodeDaramad, bool NoeAshkhas, bool Status, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblMahdoodiyatMohasebatInsert(Id, Title, AzTarikh, Tatarikh, NoeKarbar, NoeCodeDaramad, NoeAshkhas, Status, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, string AzTarikh, string Tatarikh, bool NoeKarbar, bool NoeCodeDaramad, bool NoeAshkhas, bool Status, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebatUpdate(Id, Title, AzTarikh, Tatarikh, NoeKarbar, NoeCodeDaramad, NoeAshkhas, Status, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebatDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckMahdoodiyatMohasebat
        public bool CheckMahdoodiyatMohasebat(string Tarikh, int AshkhasId, int ShomareHesabDaramad, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_CheckMahdoodiyatMohasebat(Tarikh,UserId, AshkhasId, ShomareHesabDaramad).FirstOrDefault();
                return Convert.ToBoolean(k.fldCheck);
            }
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var Mahdodiyat = m.spr_tblMahdoodiyatMohasebat_AshkhasSelect("fldMahdoodiyatMohasebatId", Id.ToString(), 0).FirstOrDefault();
                if (Mahdodiyat != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}