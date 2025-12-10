using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_Vazn_Baskool
    {
        DL_Vazn_Baskool Vazn_Baskool = new DL_Vazn_Baskool();

        #region Select
        public List<OBJ_Vazn_Baskool> Select(string FieldName, string FilterValue, int ModuleId, int OrganId, int h)
        {
            return Vazn_Baskool.Select(FieldName, FilterValue,ModuleId, OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(string harf, string fldPlaque2, string fldPlaque3, byte serial, int fldRananadeId, byte? fldNoeMasrafId, int? fldAshkhasId, int? fldChartOrganEjraeeId, int? fldLoadingPlaceId, int? fldKalaId, decimal? fldVaznKol, int? fldRemittanceId, int fldBaskoolId, bool fldIsPor, int fldTypeKhodroId,int? fldTedad,bool fldTypeMohasebe, int userId, int OrganId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldRananadeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد راننده ضروری است";
            }
            else if (fldTypeKhodroId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع خودرو ضروری است";
            }

            else if (harf == "" && fldPlaque2 == "" && fldPlaque3=="")
            {
                error.ErrorType = true;
                error.ErrorMsg = "پلاک ضروری است";
            }
            
            if (error.ErrorType == true)
                return 0;

            return Vazn_Baskool.Insert(harf, fldPlaque2, fldPlaque3, serial, fldRananadeId, fldNoeMasrafId, fldAshkhasId, fldChartOrganEjraeeId, fldLoadingPlaceId, fldKalaId, fldVaznKol, fldRemittanceId, fldBaskoolId, fldIsPor, fldTypeKhodroId,fldTedad,fldTypeMohasebe, userId, OrganId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int PlaqueId, int fldRananadeId, byte? fldNoeMasrafId, int? fldAshkhasId, int? fldChartOrganEjraeeId, int? fldLoadingPlaceId, int? fldKalaId, decimal? fldVaznKol, int? fldRemittanceId, int fldBaskoolId, bool fldIsPor, int fldTypeKhodroId,int? fldTedad,bool fldTypeMohasebe, int userId, int OrganId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (PlaqueId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پلاک ضروری است";
            }
            else if (fldRananadeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد راننده ضروری است";
            }
            else if (fldTypeKhodroId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع خودرو ضروری است";
            }


            if (error.ErrorType == true)
                return "خطا";

            return Vazn_Baskool.Update(Id, PlaqueId, fldRananadeId, fldNoeMasrafId, fldAshkhasId, fldChartOrganEjraeeId, fldLoadingPlaceId, fldKalaId, fldVaznKol, fldRemittanceId, fldBaskoolId, fldIsPor, fldTypeKhodroId,fldTedad,fldTypeMohasebe, userId, OrganId, Desc, IP);

        }
        #endregion
        #region SelectRannadeInPlaque
        public List<OBJ_Vazn_Baskool> SelectRannadeInPlaque(string FieldName, byte Serial, string Harf, string Plaque2, string Plaque3, int BaskoolId, int OrganId)
        {
            return Vazn_Baskool.SelectRannadeInPlaque(FieldName, Serial, Harf, Plaque2, Plaque3, BaskoolId,OrganId);
        }
        #endregion

        #region SelectMandeHavali
        public List<OBJ_Vazn_Baskool> SelectMandeHavali(int HavaleId, int KalaId, int BaskoolId)
        {
            return Vazn_Baskool.SelectMandeHavali(HavaleId, KalaId, BaskoolId);
        }
        #endregion

        #region SelectVaznKhals_VaznKhali
        public List<OBJ_Vazn_Baskool> SelectVaznKhals_VaznKhali(byte Serial, string Harf, string Plaque2, string Plaque3, int BaskoolId, int OrganId, decimal VaznKol, bool TypeMohasebe)
        {
            return Vazn_Baskool.SelectVaznKhals_VaznKhali(Serial, Harf, Plaque2, Plaque3, BaskoolId, OrganId, VaznKol, TypeMohasebe);
        }
        #endregion

        #region UpdateIsprintBaskool
        public string UpdateIsprintBaskool(int Id, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Vazn_Baskool.UpdateIsprintBaskool(Id);

        }
        #endregion
        #region UpdateEbtalBaskool
        public string UpdateEbtalBaskool(int Id, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Vazn_Baskool.UpdateEbtalBaskool(Id);

        }
        #endregion
    }
}