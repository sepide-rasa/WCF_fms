using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Hokm_Item
    {
        #region Detail
        public OBJ_Hokm_Item Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHokm_ItemSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Hokm_Item()
                    {
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc,
                        fldId=q.fldId,
                        fldItems_EstekhdamId=q.fldItems_EstekhdamId,
                        fldMablagh=q.fldMablagh,
                        fldPersonalHokmId=q.fldPersonalHokmId,
                        fldUserId=q.fldUserId,
                        fldZarib = q.fldZarib,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldNameItem_Estekhdam = q.fldNameItem_Estekhdam
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Hokm_Item> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHokm_ItemSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Hokm_Item()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldItems_EstekhdamId = q.fldItems_EstekhdamId,
                        fldMablagh = q.fldMablagh,
                        fldPersonalHokmId = q.fldPersonalHokmId,
                        fldUserId = q.fldUserId,
                        fldZarib = q.fldZarib,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldNameItem_Estekhdam = q.fldNameItem_Estekhdam
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHokm_ItemInsert(PersonalHokmId, Items_EstekhdamId, Mablagh, Zarib, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHokm_ItemUpdate(Id, PersonalHokmId, Items_EstekhdamId, Mablagh, Zarib, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHokm_ItemDelete(FieldName, Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblMohasebat_PersonalInfoSelect("CheckHokmId", Id.ToString(),0, 1).Any();
                return q;
            }
        }
        #endregion
    }
}