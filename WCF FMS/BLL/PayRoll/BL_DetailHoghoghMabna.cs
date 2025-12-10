using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DetailHoghoghMabna
    {
        DL_DetailHoghoghMabna DetailHoghoghMabna = new DL_DetailHoghoghMabna();
        #region Detail
        public OBJ_DetailHoghoghMabna Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return DetailHoghoghMabna.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_DetailHoghoghMabna> Select(string FieldName, string FilterValue,bool Type, int h)
        {
            return DetailHoghoghMabna.Select(FieldName, FilterValue, Type, h);
        }
        #endregion
        #region Insert
        public string Insert(int HoghoghMabnaId, byte Groh, int Mablagh, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return DetailHoghoghMabna.Insert(HoghoghMabnaId, Groh, Mablagh, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int HoghoghMabnaId, byte Groh, int Mablagh, string Desc, int UserId, string IP, out ClsError Error)
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
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return DetailHoghoghMabna.Update(Id, HoghoghMabnaId, Groh, Mablagh, Desc, UserId);
        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int Id, int UserId, string IP, out ClsError Error)
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
            if (Error.ErrorType == true)
                return "خطا";
            return DetailHoghoghMabna.Delete(FieldName,Id, UserId);
        }
        #endregion
    }
}