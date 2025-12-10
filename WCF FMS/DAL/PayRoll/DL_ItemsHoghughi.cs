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
    public class DL_ItemsHoghughi
    {
        #region Select
        public List<OBJ_ItemsHoghughi> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblItemsHoghughiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ItemsHoghughi()
                    {
                        fldId = q.fldId,
                        fldNameEN = q.fldNameEN,
                        fldTitle = q.fldTitle,
                        fldTitleHesab=q.fldTitleHesab,
                        fldType=q.fldType,
                        fldTypeHesabId=q.fldTypeHesabId,
                        fldMostamar = q.fldMostamar,
                        fldMostamarName = q.fldMostamarName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Update
        public string Update(int Id, byte TypeHesabId, byte Mostamar, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblItemsHoghughiUpdate(Id, TypeHesabId,Mostamar, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}