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
    public class DL_Items_Estekhdam
    {
        #region Select
        public List<OBJ_Items_Estekhdam> Select(string FieldName, string NoeEstekhdam,int HokmId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblItems_EstekhdamSelect(FieldName, NoeEstekhdam, HokmId, h)
                    .Select(q => new OBJ_Items_Estekhdam()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldHasZarib = q.fldHasZarib,
                        fldHasZaribstring = q.fldHasZaribstring,
                        fldId = q.fldId,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldMablagh = q.fldMablagh,
                        fldNameEN = q.fldNameEN,
                        fldTitle = q.fldTitle,
                        fldTitleItemsHoghughi = q.fldTitleItemsHoghughi,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldTypeEstekhdamTitle = q.fldTypeEstekhdamTitle,
                        fldUserId = q.fldUserId,
                        fldZarib = q.fldZarib,

                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblItems_EstekhdamUpdate(Id, Title, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}