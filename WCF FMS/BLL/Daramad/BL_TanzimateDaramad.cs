using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_TanzimateDaramad
    {
        DL_TanzimateDaramad TanzimateDaramad = new DL_TanzimateDaramad();

        #region Detail
        public OBJ_TanzimateDaramad Detail(int id,int FiscalYearId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TanzimateDaramad.Detail(id, FiscalYearId);
        }
        #endregion
        #region Select
        public List<OBJ_TanzimateDaramad> Select(string FieldName, string FilterValue, int FiscalYearId,int h)
        {
            return TanzimateDaramad.Select(FieldName, FilterValue, FiscalYearId, h);
        }
        #endregion
        #region Insert
        public string Insert(int? AvarezId, int? MaliyatId, int TakhirId, int MablaghGerdKardan, int OrganId, decimal Nerkh, bool ChapShenaseGhabz_Pardakht, byte ShorooshenaseGhabz, int ShomareHesabIdPishfarz, bool SumMaliyat_Avarez, int userId, string Desc, out ClsError error)
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
            //else if (AvarezId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد درآمد عوارض ضروری است";
            //}
            //else if (MaliyatId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد درآمد مالیات ضروری است";
            //}
            else if (TakhirId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد تاخیر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (ShomareHesabIdPishfarz == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب پیش فرض ضروری است";
            }
            //else if (TanzimateDaramad.CheckRepeatedData(AvarezId, MaliyatId, TakhirId, OrganId))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد درآمد عوارض، مالیات و تاخیر مورد نظر نباید یکسان باشد.";
            //}
           /* else if (Nerkh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نرخ ضروری است";
            }*/
            else if (Nerkh > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نرخ وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShorooshenaseGhabz < 10)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداقل مقدار شناسه قبض 10 می باشد.";
            }
            else if (ShorooshenaseGhabz > 99)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداکثر مقدار شناسه قبض 99 می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TanzimateDaramad.Insert(AvarezId, MaliyatId, TakhirId, MablaghGerdKardan, OrganId, Nerkh, ChapShenaseGhabz_Pardakht, ShorooshenaseGhabz, ShomareHesabIdPishfarz, SumMaliyat_Avarez, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int? AvarezId, int? MaliyatId, int TakhirId, int MablaghGerdKardan, int OrganId, bool ChapShenaseGhabz_Pardakht, byte ShorooshenaseGhabz, int ShomareHesabIdPishfarz,bool SumMaliyat_Avarez, int userId, string Desc, out ClsError error)
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
            //else if (AvarezId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد درآمد عوارض ضروری است";
            //}
            //else if (MaliyatId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد درآمد مالیات ضروری است";
            //}
            else if (ShomareHesabIdPishfarz == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب پیش فرض ضروری است";
            }
            else if (TakhirId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد تاخیر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (ShorooshenaseGhabz < 10)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداقل مقدار شناسه قبض 10 می باشد.";
            }
            else if (ShorooshenaseGhabz > 99)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداکثر مقدار شناسه قبض 99 می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TanzimateDaramad.Update(Id, AvarezId, MaliyatId, TakhirId, MablaghGerdKardan, OrganId, ChapShenaseGhabz_Pardakht, ShorooshenaseGhabz,ShomareHesabIdPishfarz,SumMaliyat_Avarez, userId, Desc);

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
            if (error.ErrorType == true)
                return "خطا";

            return TanzimateDaramad.Delete(id, userId);
        }
        #endregion
    }
}