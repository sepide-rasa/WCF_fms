using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_WebServiceLog
    {
        DL_WebServiceLog WebServiceLog = new DL_WebServiceLog();

        #region Detail
        public OBJ_WebServiceLog Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return WebServiceLog.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_WebServiceLog> Select(string FieldName, string FilterValue, int h)
        {
            return WebServiceLog.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Matn, string user, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (error.ErrorType == true)
                return "خطا";

            return WebServiceLog.Insert(Matn, user);

        }
        #endregion
        #region Update
        public string Update(int Id, string Matn, string user, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (error.ErrorType == true)
                return "خطا";

            return WebServiceLog.Update(Id, Matn, user);

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

            return WebServiceLog.Delete(id, userId);
        }
        #endregion
    }
}