using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Factor
    {
        DL_Factor Factor = new DL_Factor();

        #region Detail
        public OBJ_Factor Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Factor.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Factor> Select(string FieldName, string FilterValue, int h)
        {
            return Factor.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int FishId, int userId, string Desc, out ClsError error)
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
                error.ErrorMsg = "کد صدور فیش ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return Factor.Insert(FishId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int FishId, int userId, string Desc, out ClsError error)
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
                error.ErrorMsg = "کد صدور فیش ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return Factor.Update(Id, FishId, userId, Desc);

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

            return Factor.Delete(id, userId);
        }
        #endregion
    }
}