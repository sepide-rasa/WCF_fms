using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Hokm_Item
    {
        DL_Hokm_Item Hokm_Item = new DL_Hokm_Item();
        #region Detail
        public OBJ_Hokm_Item Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return Hokm_Item.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Hokm_Item> Select(string FieldName, string FilterValue, int h)
        {
            return Hokm_Item.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PersonalHokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم پرسنلی ضروری است";
            }
            else if (Items_EstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم های استخدام ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Hokm_Item.Insert(PersonalHokmId,Items_EstekhdamId,Mablagh,Zarib,UserId,Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (PersonalHokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم پرسنلی ضروری است";
            }
            else if (Items_EstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم های استخدام ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Hokm_Item.Update(Id, PersonalHokmId, Items_EstekhdamId, Mablagh, Zarib, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (Hokm_Item.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Hokm_Item.Delete(FieldName, Id, UserId);
        }
        #endregion
    }
}