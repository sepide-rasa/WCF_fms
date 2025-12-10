using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common; 

namespace WCF_FMS.BLL.Common
{
    public class BL_Error
    {
        DL_Error Error = new DL_Error();
        #region Select
        public List<OBJ_Error> Select(string FieldName, string FilterValue, int h)
        {
            return Error.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(string UserName, string Matn, System.DateTime Tarikh, string IP, Nullable<int> UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Matn == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return Error.Insert(UserName, Matn, Tarikh, IP, UserId, Desc);

        }
        #endregion
    }
}