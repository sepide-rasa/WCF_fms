using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WCF_FMS.BLL.Common
{
    public class BL_PersonalSign
    {
        DL_PersonalSign PersonalSign = new DL_PersonalSign();
        #region Select
        public List<OBJ_PersonalSign> Select(string FieldName, string FilterValue,  int h)
        {
            return PersonalSign.Select(FieldName, FilterValue,  h);
        }
        #endregion
        #region Insert
        public string Insert(int CommitionId, byte[] FileEmza, string Passvand, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (CommitionId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه حکم ضروری است";
            }
           
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return PersonalSign.Insert(CommitionId, FileEmza, Passvand, UserId, Desc, IP);
        }
        #endregion
    }
}