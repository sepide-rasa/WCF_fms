using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DetailPayeSanavati
    {
        DL_DetailPayeSanavati DetailPayeSanavati = new DL_DetailPayeSanavati();
        #region Detail
        public OBJ_DetailPayeSanavati Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return DetailPayeSanavati.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_DetailPayeSanavati> Select(string FieldName, string FilterValue, int h)
        {
            return DetailPayeSanavati.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int PayeSanavatiId, byte Groh, int Mablagh, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PayeSanavatiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پایه سنواتی ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return DetailPayeSanavati.Insert(PayeSanavatiId,Groh,Mablagh, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PayeSanavatiId, byte Groh, int Mablagh, int UserId, string Desc, out ClsError Error)
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
            else if (PayeSanavatiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پایه سنواتی ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return DetailPayeSanavati.Update(Id, PayeSanavatiId,Groh,Mablagh, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int Id, int UserId, out ClsError Error)
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
            return DetailPayeSanavati.Delete(FieldName,Id, UserId);
        }
        #endregion
    }
}