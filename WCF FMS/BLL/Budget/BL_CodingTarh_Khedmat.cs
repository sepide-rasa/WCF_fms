using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_CodingTarh_Khedmat
    {
        DL_CodingTarh_Khedmat CodingTarh_Khedmat = new DL_CodingTarh_Khedmat();

        #region Detail
        public OBJ_CodingTarh_Khedmat Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodingTarh_Khedmat.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CodingTarh_Khedmat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return CodingTarh_Khedmat.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingBudjeId, int fldEtebarTypeId, int fldTypeMasrafId, int OrganId, string fldAddress, int? fldHoghoghiId, int? fldHaghighiId, short fldStartYear,
            short fldEndYear, int fldValue, long fldPriceVahed, long fldKolEtebar, int userId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (fldAddress == null)
                fldAddress = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldCodingBudjeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کدینگ بودجه ضروری است";
            }
            else if (fldEtebarTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع اعتبار ضروری است";
            }
            else if (fldTypeMasrafId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع مصرف ضروری است";
            }
            else if (fldStartYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال شروع ضروری است";
            }
            else if (fldValue == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (fldEndYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال پایان ضروری است";
            }
            else if (fldPriceVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ واحد ضروری است";
            }
            else if (fldKolEtebar == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کل اعتبار ضروری است";
            }
           

            if (error.ErrorType == true)
                return "خطا";

            return CodingTarh_Khedmat.Insert(fldCodingBudjeId, fldEtebarTypeId, fldTypeMasrafId, OrganId, fldAddress, fldHoghoghiId, fldHaghighiId, fldStartYear, fldEndYear,
                    fldValue, fldPriceVahed, fldKolEtebar, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldCodingBudjeId, int fldEtebarTypeId, int fldTypeMasrafId, int OrganId, string fldAddress, int? fldHoghoghiId, int? fldHaghighiId, short fldStartYear,
            short fldEndYear, int fldValue, long fldPriceVahed, long fldKolEtebar, int userId, string Desc, string IP, out ClsError error)
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
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldCodingBudjeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کدینگ بودجه ضروری است";
            }
            else if (fldEtebarTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع اعتبار ضروری است";
            }
            else if (fldTypeMasrafId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع مصرف ضروری است";
            }
            else if (fldStartYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال شروع ضروری است";
            }
            else if (fldValue == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (fldEndYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال پایان ضروری است";
            }
            else if (fldPriceVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ واحد ضروری است";
            }
            else if (fldKolEtebar == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کل اعتبار ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return CodingTarh_Khedmat.Update(Id, fldCodingBudjeId, fldEtebarTypeId, fldTypeMasrafId, OrganId, fldAddress, fldHoghoghiId, fldHaghighiId, fldStartYear, fldEndYear,
                    fldValue, fldPriceVahed, fldKolEtebar, userId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodingTarh_Khedmat.Delete(id, userId);
        }
        #endregion
    }
}