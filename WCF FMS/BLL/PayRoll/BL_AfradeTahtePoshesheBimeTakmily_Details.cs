using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_AfradeTahtePoshesheBimeTakmily_Details
    {
        DL_AfradeTahtePoshesheBimeTakmily_Details AfradeTahtePoshesheBimeTakmily_Details = new DL_AfradeTahtePoshesheBimeTakmily_Details();
        #region Detail
        public OBJ_AfradeTahtePoshesheBimeTakmily_Details Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return AfradeTahtePoshesheBimeTakmily_Details.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_AfradeTahtePoshesheBimeTakmily_Details> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return AfradeTahtePoshesheBimeTakmily_Details.Select(FieldName, FilterValue,  FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(int AfradTahtePoshehsId, int BimeTakmiliId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (AfradTahtePoshehsId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد افراد تحت پوشش ضروری است";
            }
            else if (BimeTakmiliId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بیمه تکمیلی ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return AfradeTahtePoshesheBimeTakmily_Details.Insert(AfradTahtePoshehsId, BimeTakmiliId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int AfradTahtePoshehsId, int BimeTakmiliId, int UserId, string Desc, out ClsError Error)
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

            else if (AfradTahtePoshehsId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد افراد تحت پوشش ضروری است";
            }
            else if (BimeTakmiliId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بیمه تکمیلی ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return AfradeTahtePoshesheBimeTakmily_Details.Update(Id, AfradTahtePoshehsId, BimeTakmiliId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
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
            if (Error.ErrorType == true)
                return "خطا";
            return AfradeTahtePoshesheBimeTakmily_Details.Delete(Id, UserId);
        }
        #endregion


    }
}