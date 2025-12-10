using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Archive;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.BLL.Archive
{
    public class BL_PropertiesValues
    {
        DL_PropertiesValues PropertiesValues = new DL_PropertiesValues();

        #region Detail
        public OBJ_PropertiesValues Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PropertiesValues.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PropertiesValues> Select(string FieldName, string FilterValue, int h)
        {
            return PropertiesValues.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ParticularId, string Value, int userId, string Desc, out ClsError error)
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
            else if (Value == "" || Value == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (ParticularId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد خاصیت ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PropertiesValues.Insert(ParticularId, Value, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ParticularId, string Value, int userId, string Desc, out ClsError error)
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
            else if (Value == "" || Value == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (ParticularId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد خاصیت ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PropertiesValues.Update(Id, ParticularId, Value, userId, Desc);

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

            return PropertiesValues.Delete(id, userId);
        }
        #endregion
    }
}