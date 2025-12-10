using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SavabeghJebhe_Personal
    {
        DL_SavabeghJebhe_Personal SavabeghJebhe_Personal = new DL_SavabeghJebhe_Personal();
        #region Detail
        public OBJ_SavabeghJebhe_Personal Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه انواع استخدام ضروری است";
            }
            return SavabeghJebhe_Personal.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_SavabeghJebhe_Personal> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            return SavabeghJebhe_Personal.Select(FieldName, FilterValue,FilterValue1, h);
        }
        #endregion
        #region Insert
        public string Insert(int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ItemId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم های سوابق جبهه ضروری است";
            }
            else if (PrsPersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد اشخاص حقیقی ضروری است";
            }
            else if (AzTarikh == "" || AzTarikh == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (TaTarikh == "" || TaTarikh == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تا تاریخ ضروری است";
            }
            else if (!r.IsMatch(AzTarikh) || !r.IsMatch(TaTarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(TaTarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (SavabeghJebhe_Personal.CheckBazeZamani(0, PrsPersonalId, AzTarikh, TaTarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "بازه انتخاب شده با اطلاعات از پیش ثبت شده تداخل زمانی دارد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return SavabeghJebhe_Personal.Insert(ItemId, PrsPersonalId, AzTarikh, TaTarikh, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه انواع استخدام ضروری است";
            }
            else if (ItemId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم های سوابق جبهه ضروری است";
            }
            else if (PrsPersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد اشخاص حقیقی ضروری است";
            }
            else if (AzTarikh == "" || AzTarikh == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (TaTarikh == "" || TaTarikh == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تا تاریخ ضروری است";
            }
            else if (!r.IsMatch(AzTarikh) || !r.IsMatch(TaTarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(TaTarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (SavabeghJebhe_Personal.CheckBazeZamani(Id, PrsPersonalId, AzTarikh, TaTarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "بازه انتخاب شده با اطلاعات از پیش ثبت شده تداخل زمانی دارد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return SavabeghJebhe_Personal.Update(Id, ItemId, PrsPersonalId, AzTarikh, TaTarikh, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
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
            if (Error.ErrorType == true)
                return "خطا";
            return SavabeghJebhe_Personal.Delete(Id, UserId);
        }
        #endregion
    }
}