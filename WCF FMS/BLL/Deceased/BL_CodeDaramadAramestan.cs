using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_CodeDaramadAramestan
    {
        DL_CodeDaramadAramestan CodeDaramadAramestan = new DL_CodeDaramadAramestan();

        #region Detail
        public OBJ_CodeDaramadAramestan Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodeDaramadAramestan.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CodeDaramadAramestan> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return CodeDaramadAramestan.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldCodeDaramadId, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodeDaramadAramestan.Insert(fldCodeDaramadId,OrganId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldCodeDaramadId, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodeDaramadAramestan.Update(fldId, fldCodeDaramadId,OrganId, userId, Desc, IP);

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

            return CodeDaramadAramestan.Delete(id, userId);
        }
        #endregion
    }
}