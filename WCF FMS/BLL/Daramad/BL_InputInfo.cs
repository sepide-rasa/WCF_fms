using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_InputInfo
    {
        DL_InputInfo InputInfo = new DL_InputInfo();
        #region Select
        public List<OBJ_InputInfo> Select(string FieldName, string FilterValue, bool LoginType, int h)
        {
            return InputInfo.Select(FieldName, FilterValue,LoginType, h);
        }
        #endregion
        #region Insert
        public string Insert(System.DateTime fldDateTime, string fldIP, string fldMACAddress, bool fldLoginType, int userId, string Desc, out ClsError error)
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
            if (error.ErrorType == true)
                return "خطا";

            return InputInfo.Insert(fldDateTime, fldIP, fldMACAddress, fldLoginType, userId, Desc);

        }
        #endregion
    }
}