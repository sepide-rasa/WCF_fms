using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_Vazn_Baskool
    {
        #region Select
        public List<OBJ_Vazn_Baskool> Select(string FieldName, string FilterValue,int ModuleId, int OrganId, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblVazn_BaskoolSelect(FieldName, FilterValue, ModuleId, OrganId, h)
                    .Select(q => new OBJ_Vazn_Baskool()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldBaskoolId = q.fldBaskoolId,
                        fldIP = q.fldIP,
                        fldKalaId = q.fldKalaId,
                        fldPluqeId = q.fldPluqeId,
                        fldOrganId = q.fldOrganId,
                        fldRananadeId = q.fldRananadeId,
                        fldNoeMasrafId = q.fldNoeMasrafId,
                        fldAshkhasId = q.fldAshkhasId,
                        fldChartOrganEjraeeId = q.fldChartOrganEjraeeId,
                        fldLoadingPlaceId = q.fldLoadingPlaceId,
                        fldVaznKol = q.fldVaznKol,
                        fldVaznKhals = q.fldVaznKhals,
                        fldRemittanceId = q.fldRemittanceId,
                        fldTarikhVaznKhali = q.fldTarikhVaznKhali,
                        fldNameRanande = q.fldNameRanande,
                        fldNameKala = q.fldNameKala,
                        fldNamePlace = q.fldNamePlace,
                        fldPlaque = q.fldPlaque,
                        fldDateTazin = q.fldDateTazin,
                        fldTarikh_TimeTozin = q.fldTarikh_TimeTozin,
                        fldIsPor = q.fldIsPor,
                        fldIsporName = q.fldIsporName,
                        fldBaghimande = q.fldBaghimande,
                        fldCountHavale = q.fldCountHavale,
                        fldVaznKhali = q.fldVaznKhali,
                        fldTypeKhodroId = q.fldTypeKhodroId,
                        fldNameKhodro = q.fldNameKhodro,
                        fldNameAshkhas = q.fldNameAshkhas,
                        fldNameChart = q.fldNameChart,
                        fldNameHavale = q.fldNameHavale,
                        fldNameMasraf = q.fldNameMasraf,
                        fldTarfHesab = q.fldTarfHesab,
                        fldIsprint = q.fldIsprint,
                        fldEbtal = q.fldEbtal,
                        fldElamAvarezId=q.fldElamAvarezId,
                        fldFishId=q.fldFishId,
                        fldTedad=q.fldTedad,
                        fldTypeMohasebe = q.fldTypeMohasebe
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public int Insert(string harf, string fldPlaque2, string fldPlaque3, byte serial, int fldRananadeId, byte? fldNoeMasrafId, int? fldAshkhasId, int? fldChartOrganEjraeeId, int? fldLoadingPlaceId, int? fldKalaId, decimal? fldVaznKol, int? fldRemittanceId, int fldBaskoolId, bool fldIsPor, int fldTypeKhodroId,int? fldTedad,bool fldTypeMohasebe, int userId, int OrganId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblVazn_BaskoolInsert(Id, harf, fldPlaque2, fldPlaque3, serial, fldRananadeId, fldNoeMasrafId, fldAshkhasId, fldChartOrganEjraeeId, fldLoadingPlaceId, fldKalaId, fldVaznKol, fldRemittanceId, fldBaskoolId, fldIsPor, fldTypeKhodroId,fldTedad,fldTypeMohasebe, userId, OrganId, Desc, IP);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id,int PlaqueId, int fldRananadeId, byte? fldNoeMasrafId, int? fldAshkhasId, int? fldChartOrganEjraeeId, int? fldLoadingPlaceId, int? fldKalaId, decimal? fldVaznKol, int? fldRemittanceId, int fldBaskoolId, bool fldIsPor, int fldTypeKhodroId,int? fldTedad,bool fldTypeMohasebe, int userId, int OrganId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {

                p.spr_tblVazn_BaskoolUpdate(Id,PlaqueId, fldRananadeId, fldNoeMasrafId, fldAshkhasId, fldChartOrganEjraeeId, fldLoadingPlaceId, fldKalaId, fldVaznKol, fldRemittanceId, fldBaskoolId, fldIsPor, fldTypeKhodroId,fldTedad,fldTypeMohasebe, userId, OrganId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region SelectRannadeInPlaque
        public List<OBJ_Vazn_Baskool> SelectRannadeInPlaque(string FieldName,byte Serial, string Harf, string Plaque2, string Plaque3,int BaskoolId,int OrganId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_SelectRannadeInPlaque(FieldName, Serial, Harf, Plaque2, Plaque3, BaskoolId,OrganId)
                    .Select(q => new OBJ_Vazn_Baskool()
                    {
                        fldRananadeId = q.fldRananadeId,
                        fldNameRanande = q.fldNameRanande,
                        IsKhali = q.IsKhali,
                        fldTypeKhodroId = q.fldTypeKhodro,
                        fldNameKhodro = q.fldNameKhodro
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region SelectMandeHavali
        public List<OBJ_Vazn_Baskool> SelectMandeHavali(int HavaleId, int KalaId, int BaskoolId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_SelectMandeHavali(HavaleId, BaskoolId, KalaId)
                    .Select(q => new OBJ_Vazn_Baskool()
                    {
                        fldBaghimande = q.fldBaghimande,
                        fldCountHavale = q.fldCountHavale,
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region SelectVaznKhals_VaznKhali
        public List<OBJ_Vazn_Baskool> SelectVaznKhals_VaznKhali(byte Serial, string Harf, string Plaque2, string Plaque3, int BaskoolId, int OrganId, decimal VaznKol, bool TypeMohasebe)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_SelectVaznKhals_VaznKhali(Harf, Plaque2, Plaque3, Serial, BaskoolId, OrganId, VaznKol,TypeMohasebe)
                    .Select(q => new OBJ_Vazn_Baskool()
                    {
                        fldVaznKhali = q.fldVaznKhali,
                        fldVaznKhals = q.fldVaznKhals,
                        fldTarikhVaznKhali = q.TarikhVaznKhali,
                        lastHour = q.lastHour
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region UpdateIsprintBaskool
        public string UpdateIsprintBaskool(int Id)
        {
            using (WeighEntities p = new WeighEntities())
            {

                p.spr_UpdateIsprintBaskool(Id);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateEbtalBaskool
        public string UpdateEbtalBaskool(int Id)
        {
            using (WeighEntities p = new WeighEntities())
            {

                p.spr_UpdateEbtalBaskool(Id);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}