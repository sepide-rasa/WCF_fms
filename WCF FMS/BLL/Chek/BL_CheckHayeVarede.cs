using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Chek;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.BLL.Chek
{
    public class BL_CheckHayeVarede
    {
        DL_CheckHayeVarede CheckHayeVarede = new DL_CheckHayeVarede();

        #region Detail
        public OBJ_CheckHayeVarede Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CheckHayeVarede.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CheckHayeVarede> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return CheckHayeVarede.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int ShobeId, int Mablagh, int AshkhasId, string TarikhVosolCheck, string TarikhDaryaftCheck, string ShenaseKamelCheck, string Babat, bool NoeeCheck, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (ShobeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو چک ضروری است";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "صادر کننده ضروری است";
            }
            else if (TarikhVosolCheck == "" || TarikhVosolCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ وصول ضروری است";
            }
            else if (TarikhDaryaftCheck == "" || TarikhDaryaftCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ دریافتی ضروری است";
            }
            else if (ShenaseKamelCheck == "" || ShenaseKamelCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کامل چک ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CheckHayeVarede.Insert(ShobeId, Mablagh, AshkhasId, TarikhVosolCheck, TarikhDaryaftCheck, ShenaseKamelCheck, Babat, NoeeCheck, OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShobeId, int Mablagh, int AshkhasId, string TarikhVosolCheck, string TarikhDaryaftCheck, string ShenaseKamelCheck, string Babat, bool NoeeCheck, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (ShobeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو چک ضروری است";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "صادر کننده ضروری است";
            }
            else if (TarikhVosolCheck == "" || TarikhVosolCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ وصول ضروری است";
            }
            else if (TarikhDaryaftCheck == "" || TarikhDaryaftCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ دریافتی ضروری است";
            }
            else if (ShenaseKamelCheck == "" || ShenaseKamelCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کامل چک ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CheckHayeVarede.Update(Id, ShobeId, Mablagh, AshkhasId, TarikhVosolCheck, TarikhDaryaftCheck, ShenaseKamelCheck, Babat, NoeeCheck, OrganId, userId, Desc);

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
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (CheckHayeVarede.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CheckHayeVarede.Delete(id, userId);
        }
        #endregion
    }
}