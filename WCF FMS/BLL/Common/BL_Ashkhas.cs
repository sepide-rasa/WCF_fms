using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Ashkhas
    {
        DL_Ashkhas Ashkhas = new DL_Ashkhas();

        #region Detail
        public OBJ_Ashkhas Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Ashkhas.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Ashkhas> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            return Ashkhas.Select(FieldName, FilterValue,FilterValue1, h);
        }
        #endregion
        #region Insert
        public string Insert(Nullable<int> HaghighiId, Nullable<int> HoghoghiId, int userId, string Desc, out ClsError error)
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
                else if (Ashkhas.CheckRepeatedRow(HaghighiId, HoghoghiId, 0))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
                }
            if (error.ErrorType == true)
                return "خطا";

            return Ashkhas.Insert(HaghighiId, HoghoghiId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, Nullable<int> HaghighiId, Nullable<int> HoghoghiId, int userId, string Desc, out ClsError error)
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
                else if (Ashkhas.CheckRepeatedRow(HaghighiId, HoghoghiId, Id))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
                }
            if (error.ErrorType == true)
                return "خطا";

            return Ashkhas.Update(Id, HaghighiId, HoghoghiId, userId, Desc);

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
            else if (Ashkhas.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ashkhas.Delete(id, userId);
        }
        #endregion
        
    }
}