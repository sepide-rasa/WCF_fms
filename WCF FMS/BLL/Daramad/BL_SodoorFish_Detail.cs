using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_SodoorFish_Detail
    {
        DL_SodoorFish_Detail SodoorFish_Detail = new DL_SodoorFish_Detail();

        #region Detail
        public OBJ_SodoorFish_Detail Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return SodoorFish_Detail.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_SodoorFish_Detail> Select(string FieldName, string FilterValue, int h)
        {
            return SodoorFish_Detail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int FishId, int CodeElamAvarezId, int userId, string Desc, out ClsError error)
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
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فیش ضروری است";
            }
            else if (CodeElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد اعلام عوارض ضروری است";
            }
            else if (SodoorFish_Detail.CheckRepeatedRow(FishId, CodeElamAvarezId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "برای اعلام عوارض مورد نظر قبلا فیش صادر شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodoorFish_Detail.Insert(FishId, CodeElamAvarezId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int FishId, int CodeElamAvarezId, int userId, string Desc, out ClsError error)
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
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فیش ضروری است";
            }
            else if (CodeElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد اعلام عوارض ضروری است";
            }
            else if (SodoorFish_Detail.CheckRepeatedRow(FishId, CodeElamAvarezId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "برای اعلام عوارض مورد نظر قبلا فیش صادر شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodoorFish_Detail.Update(Id, FishId, CodeElamAvarezId, userId, Desc);

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

            return SodoorFish_Detail.Delete(id, userId);
        }
        #endregion
    }
}