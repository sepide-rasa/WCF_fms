using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_ItemsEstekhdam_FiscalTitle
    {
        #region Select
        public List<OBJ_ItemsEstekhdam_FiscalTitle> Select(string FieldName, string NoeEstekhdam, int FiscalHeaderId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblItemsEstekhdam_FiscalTitleSelect(FieldName, NoeEstekhdam, FiscalHeaderId, h)
                    .Select(q => new OBJ_ItemsEstekhdam_FiscalTitle()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        flAnvaEstekhdamId = q.flAnvaEstekhdamId,
                        fldAnvaEstekhdamTitle = q.fldAnvaEstekhdamTitle,
                        fldHasZarib = q.fldHasZarib,
                        fldHasZaribName = q.fldHasZaribName,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldMashmul = q.fldMashmul,
                        fldTitle = q.fldTitle,
                        fldTitleItemsHoghughi = q.fldTitleItemsHoghughi,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldMashmoolDefaultTax=q.fldMashmoolDefaultTax,
                        fldNameDefaultTax=q.fldNameDefaultTax
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}