using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_ParametrBaskoolValue
    {
        DL_ParametrBaskoolValue ParametrBaskoolValue = new DL_ParametrBaskoolValue();

    
        #region Select
        public List<OBJ_ParametrBaskoolValue> Select(string FieldName, string FilterValue, int h)
        {
            return ParametrBaskoolValue.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldParametrBaskoolId, int fldBaskoolId, string fldValue, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldParametrBaskoolId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامترهای باسکول ضروری است";
            }
            else if (fldBaskoolId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد باسکول ضروری است";
            }
            else if (fldValue == "" || fldValue == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return ParametrBaskoolValue.Insert(fldParametrBaskoolId, fldBaskoolId, fldValue, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldParametrBaskoolId, int fldBaskoolId, string fldValue, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldParametrBaskoolId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامترهای باسکول ضروری است";
            }
            else if (fldBaskoolId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد باسکول ضروری است";
            }
            else if (fldValue == "" || fldValue == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametrBaskoolValue.Update(fldId, fldParametrBaskoolId, fldBaskoolId, fldValue, userId, Desc, IP);

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

            return ParametrBaskoolValue.Delete(id, userId);
        }
        #endregion
        #region SelectBaskoolParametr_Value
        public List<OBJ_BaskoolParametr_Value> SelectBaskoolParametr_Value(int BaskoolId)
        {
            return ParametrBaskoolValue.SelectBaskoolParametr_Value(BaskoolId);
        }
        #endregion
    }
}