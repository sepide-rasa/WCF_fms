using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PardakhtFish
    {
        DL_PardakhtFish PardakhtFish = new DL_PardakhtFish();

        #region Detail
        public OBJ_PardakhtFish Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PardakhtFish.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PardakhtFish> Select(string FieldName, string FilterValue, int h)
        {
            return PardakhtFish.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int FishId, System.DateTime DatePardakht, int NahvePardakhtId, Nullable<int> PardakhtFiles_DetailId, System.DateTime DateVariz, int userId, string Desc, out ClsError error)
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
            else if (DatePardakht == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (DateVariz == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ واریز ضروری است";
            }
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فیش ضروری است";
            }
            else if (NahvePardakhtId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نحوه پرداخت ضروری است";
            }
            else if (PardakhtFish.CheckRepeatedRow(FishId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات پرداخت قبلا در سیستم ثبت شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PardakhtFish.Insert(FishId, DatePardakht, NahvePardakhtId, PardakhtFiles_DetailId, DateVariz, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int FishId, System.DateTime DatePardakht, int NahvePardakhtId, Nullable<int> PardakhtFiles_DetailId, System.DateTime DateVariz, int userId, string Desc, out ClsError error)
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
            else if (DatePardakht == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (DateVariz == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ واریز ضروری است";
            }
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فیش ضروری است";
            }
            else if (NahvePardakhtId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نحوه پرداخت ضروری است";
            }
            else if (PardakhtFish.CheckRepeatedRow(FishId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات پرداخت قبلا در سیستم ثبت شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PardakhtFish.Update(Id, FishId, DatePardakht, NahvePardakhtId, PardakhtFiles_DetailId, DateVariz, userId, Desc);

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

            return PardakhtFish.Delete(id, userId);
        }
        #endregion
    }
}