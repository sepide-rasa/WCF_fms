using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Chek;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.BLL.Chek
{
    public class BL_StatusChek
    {
        DL_StatusChek StatusChek = new DL_StatusChek();
        #region Insert
        public string Insert(Nullable<int> SodorCheckId, Nullable<int> CheckVaredeId, Nullable<int> AghsatId, byte Status, string Tarikh, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Tarikh == "" || Tarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (Status == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return StatusChek.Insert(SodorCheckId, CheckVaredeId, AghsatId, Status, Tarikh, userId, Desc);

        }
        #endregion
    }
}