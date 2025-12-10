using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DAL_ShomareHesabCodeDaramad_Fomula
    {
        #region Select
        public List<OBJ_ShomareHesabCodeDaramad_Fomula> Select(string FieldName, string FilterValue,int organid, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblShomareHesab_FormulaSelect(FieldName, FilterValue,organid, h)
                    .Select(q => new OBJ_ShomareHesabCodeDaramad_Fomula()
                    {
                        fldDate=q.fldDate,
                        fldFormolsaz=q.fldFormolsaz,
                        fldFormulKoliId=q.fldFormulKoliId,
                        fldFormulMohasebatId=q.fldFormulMohasebatId,
                        fldId=q.fldId,
                        fldShomareHesab_CodeId=q.fldShomareHesab_CodeId,
                        fldTarikhEjra=q.fldTarikhEjra,
                        fldUserId=q.fldUserId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesab_CodeId,string Formul,string TarikhEjra, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblShomareHesab_FormulaInsert(ShomareHesab_CodeId, Formul, null, null, TarikhEjra, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesab_CodeId, string Formul, string TarikhEjra, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblShomareHesab_FormulaUpdate(Id, ShomareHesab_CodeId, Formul, TarikhEjra, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}