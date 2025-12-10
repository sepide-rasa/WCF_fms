using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_ItemsEstekhdam_MoteghayerHoghoghi
    {
        #region Select
        public List<OBJ_ItemsEstekhdam_MoteghayerHoghoghi> Select(string FieldName, string NoeEstekhdam,int HeaderId , int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblItemsEstekhdam_MoteghayerHoghoghiSelect(FieldName, NoeEstekhdam,HeaderId, h)
                    .Select(q => new OBJ_ItemsEstekhdam_MoteghayerHoghoghi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        flAnvaeEstekhdamId = q.flAnvaeEstekhdamId,
                        fldAnvaeEstekhdamTitle = q.fldAnvaeEstekhdamTitle,
                        fldHasZarib = q.fldHasZarib,
                        fldHasZaribstring = q.fldHasZaribstring,
                        fldItemsHoghughiId = q.fldItemsHoghughiId,
                        fldTitle = q.fldTitle,
                        fldTitleItemsHoghughi = q.fldTitleItemsHoghughi,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldMazayaMashmool=q.fldMazayaMashmool
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}