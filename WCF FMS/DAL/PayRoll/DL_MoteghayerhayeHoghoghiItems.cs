using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;


namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MoteghayerhayeHoghoghiItems
    {
        #region Detail
        public OBJ_MoteghayerhayeHoghoghiItems Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeHoghoghiItemsSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MoteghayerhayeHoghoghiItems()
                    {
                        fldDate = q.fldDate,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldType = q.fldType,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldMoteghayerhayeHoghoghiId = q.fldMoteghayerhayeHoghoghiId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeHoghoghiItems> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeHoghoghiItemsSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MoteghayerhayeHoghoghiItems()
                    {
                        fldDate = q.fldDate,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldType = q.fldType,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldMoteghayerhayeHoghoghiId = q.fldMoteghayerhayeHoghoghiId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghiItemsInsert(MoteghayerhayeHoghoghiId, ItemEstekhdamId, fldType, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghiItemsUpdate(MoteghayerhayeHoghoghiId, ItemEstekhdamId, fldType, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghiItemsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}