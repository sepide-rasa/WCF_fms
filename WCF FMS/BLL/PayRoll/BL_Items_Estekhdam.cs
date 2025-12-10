using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Items_Estekhdam
    {
        DL_Items_Estekhdam Items_Estekhdam = new DL_Items_Estekhdam();
        #region Select
        public List<OBJ_Items_Estekhdam> Select(string FieldName, string NoeEstekhdam, int HokmId, int h)
        {
            return Items_Estekhdam.Select(FieldName, NoeEstekhdam,HokmId, h);
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }

            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 400)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }

            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Items_Estekhdam.Update(Id, Title, UserId);
        }
        #endregion
    }
}