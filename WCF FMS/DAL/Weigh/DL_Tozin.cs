using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_Tozin
    {
        #region Select
        public List<OBJ_Tozin> Select(string FieldName, string FilterValue, string FilterValue2, string AzTarikh, string TaTarikh, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblTozinSelect(FieldName, FilterValue, FilterValue2, AzTarikh, TaTarikh, h)
                    .Select(q => new OBJ_Tozin()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldWeighbridgeId = q.fldWeighbridgeId,
                        fldMaxW = q.fldMaxW,
                        fldPlaqueId = q.fldPlaqueId,
                        fldHour = q.fldHour,
                        fldStartDate = q.fldStartDate,
                        fldEndDate = q.fldEndDate,
                        fldPlaque = q.fldPlaque,
                        fldNameBaskool = q.fldNameBaskool,
                        fldTarikhShoroo = q.fldTarikhShoroo,
                        fldTarikhPayan = q.fldTarikhPayan,
                        fldSaat = q.fldSaat
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldWeighbridgeId, int fldMaxW, int? fldPlaqueId, DateTime fldHour, DateTime fldStartDate, DateTime fldEndDate)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblTozinInsert(fldWeighbridgeId, fldMaxW, fldPlaqueId, fldHour, fldStartDate, fldEndDate);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}