using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SayerPardakhtGroup
    {
        #region Select
        public List<OBJ_SayerPardakhtGroup> Select(string FieldName, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int CostCenterId, int? BankId, byte Type, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSayerPardakhtGroupSelect(FieldName, Year, Month, NobatPardakht, MarhalePardakht, CostCenterId, BankId, Type, OrganId)
                    .Select(q => new OBJ_SayerPardakhtGroup()
                    {
                        Expr1 = q.Expr1,
                        fldAmount = q.fldAmount,
                        fldChecked = q.fldChecked,
                        fldCodemeli = q.fldCodemeli,
                        fldCostCenterId = q.fldCostCenterId,
                        fldMarhalePardakht = q.fldMarhalePardakht,
                        fldMonth = q.fldMonth,
                        fldName = q.fldName,
                        fldNobatePardakt = q.fldNobatePardakt,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldSayerPardakhtId = q.fldSayerPardakhtId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTitle = q.fldTitle,
                        fldYear = q.fldYear,
                        fldShomareHesab = q.fldShomareHesab,
                        fldMoafAsMaliyat = q.fldMoafAsMaliyat,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMaliyat = q.fldMaliyat,
                        fldHasMaliyat = q.fldHasMaliyat,
                        fldShomareHesabsId = q.fldShomareHesabsId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}