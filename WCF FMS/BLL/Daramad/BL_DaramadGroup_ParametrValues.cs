using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_DaramadGroup_ParametrValues
    {
        DL_DaramadGroup_ParametrValues DaramadGroup_ParametrValues = new DL_DaramadGroup_ParametrValues();

        #region Detail
        public OBJ_DaramadGroup_ParametrValues Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DaramadGroup_ParametrValues.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_DaramadGroup_ParametrValues> Select(string FieldName, string FilterValue, int h)
        {
            return DaramadGroup_ParametrValues.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ElamAvarezId, int ParametrGroupDaramadId, string Value, int userId, string Desc, out ClsError error)
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
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (ParametrGroupDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامتر گروه درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DaramadGroup_ParametrValues.Insert(ElamAvarezId, ParametrGroupDaramadId, Value, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, int ParametrGroupDaramadId, string Value, int userId, string Desc, out ClsError error)
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
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (ParametrGroupDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پارامتر گروه درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DaramadGroup_ParametrValues.Update(Id, ElamAvarezId, ParametrGroupDaramadId, Value, userId, Desc);

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

            return DaramadGroup_ParametrValues.Delete(id, userId);
        }
        #endregion
    }
}