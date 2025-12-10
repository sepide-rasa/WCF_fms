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
    public class BL_Masoulin
    {
        DL_Masoulin Masoulin = new DL_Masoulin();
        #region Detail
        public OBJ_Masoulin Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return Masoulin.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Masoulin> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Masoulin.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string TarikhEjra, int Module_OrganId, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Module_OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (TarikhEjra == "" || TarikhEjra == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (!r.IsMatch(TarikhEjra))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (Masoulin.CheckRepeatedRow(TarikhEjra, Module_OrganId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }      
            /*if (Error.ErrorType == false)
            {
                if (Masoulin.CheckRepeatedRow(ModuleId,TarikhEjra,Detail,0))
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
                }
            }*/
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Masoulin.Insert(TarikhEjra, Module_OrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string TarikhEjra, int Module_OrganId, int UserId, string Desc, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (Module_OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (TarikhEjra == "" || TarikhEjra == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (!r.IsMatch(TarikhEjra))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (Masoulin.CheckRepeatedRow(TarikhEjra, Module_OrganId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            /*else if (Detail == null || Detail.Count == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "جزئیات مسئولین ضروری است";
            }
            else
            {
                foreach (var item in Detail)
                {
                    if (item.fldEmployeeId == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شناسه کارمند ضروری است";
                        break;
                    }
                    if (item.fldOrganId == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شناسه سازمان ضروری است";
                        break;
                    }
                }
            }*/
            /*if (Error.ErrorType == false)
            {
                if (Masoulin.CheckRepeatedRow(ModuleId,TarikhEjra,Detail,Id))
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
                }
            }*/
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Masoulin.Update(Id, TarikhEjra, Module_OrganId, UserId, Desc);
        }
        #endregion
        #region SelectMasuolin_ZirList
        public List<OBJ_Masuolin_ZirList> SelectMasuolin_ZirList(int headerId)
        {
            return Masoulin.SelectMasuolin_ZirList(headerId);
        }
        #endregion
    }
}